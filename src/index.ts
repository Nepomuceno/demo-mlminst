import { HubConnectionBuilder, LogLevel } from "@aspnet/signalr";

var hub = new HubConnectionBuilder()
  .withUrl("https://localhost:5001/hub")
  //.withUrl("https://aidrawn.azurewebsites.net/hub")
  .configureLogging(LogLevel.Information)
  .build();

var counterHorizontal = 0;
var counterVertical = 0;
var backgroundScale = 5;
var maxHorizontal = 1;

var flag = false,
  prevX = 0,
  currX = 0,
  prevY = 0,
  currY = 0,
  dot_flag = false;

async function backgroundDrawning(content: Array<number>, guess: number, probability?: number): Promise<any> {
  let c = <HTMLCanvasElement>document.getElementById("c");
  var ctx = <CanvasRenderingContext2D>c.getContext("2d");
  maxHorizontal = Math.floor(c.width/(28*backgroundScale));
  var imageData = ctx.getImageData(0, 0, 28, 28);
  var buffer = new ArrayBuffer(content.length * 4);
  var buf8 = new Uint8ClampedArray(buffer);
  var data = new Uint32Array(buffer);
  var redValue = probability ? Math.floor(255-(255*probability)) : 0;
  var greenValue = probability ? Math.floor(255*probability) : 0;
  for (let i = 0; i < content.length; i++) {
    data[i] =
      (content[i] << 24) | // alpha
      (0 << 16)          | // blue 
      (greenValue << 8)  | // green
      redValue               // red
  }
  imageData.data.set(buf8);
  console.log(`Data: ${imageData.data.length}`);
  imageData = scaleImageData(imageData, backgroundScale);
  console.log(`Data: ${imageData.data.length}`);
  ctx.strokeText(guess.toString(), (counterHorizontal * 28 * backgroundScale), (counterVertical * 28 * backgroundScale), 20)
  ctx.putImageData(imageData, (counterHorizontal * 28 * backgroundScale), (counterVertical * 28 * backgroundScale));
  counterHorizontal++;
  if(counterHorizontal % maxHorizontal == 0)
  {
    counterVertical++;
    counterHorizontal = 0;
  }

}



function findxy(res: string, e: MouseEvent, ctx: CanvasRenderingContext2D) {
  if (res == "down") {
    prevX = currX;
    prevY = currY;
    currX = e.offsetX;
    currY = e.offsetY;

    flag = true;
    dot_flag = true;
    if (dot_flag) {
      ctx.beginPath();
      ctx.fillStyle = "#000000";
      ctx.fillRect(currX, currY, 10, 10);
      ctx.closePath();
      dot_flag = false;
    }
  }
  if (res == "up" || res == "out") {
    flag = false;
  }
  if (res == "move") {
    if (flag) {
      prevX = currX;
      prevY = currY;
      currX = e.offsetX;
      currY = e.offsetY;
      draw(ctx);
    }
  }
}
function draw(ctx: CanvasRenderingContext2D) {
  ctx.beginPath();
  ctx.moveTo(prevX, prevY);
  ctx.lineTo(currX, currY);
  ctx.strokeStyle = "black";
  ctx.lineWidth = 10;
  ctx.stroke();
  ctx.closePath();
}

async function setUpDrawning(): Promise<any> {
  const canvas = <HTMLCanvasElement>document.getElementById("draw");
  const ctx = canvas.getContext("2d");
  if (ctx == null) return;

  canvas.addEventListener(
    "mousemove",
    e => {
      findxy("move", e, ctx);
    },
    false
  );
  canvas.addEventListener(
    "mousedown",
    e => {
      console.log(`down`);
      findxy("down", e, ctx);
    },
    false
  );
  canvas.addEventListener(
    "mouseup",
    async e => {
      findxy("up", e, ctx);
      var data = ctx.getImageData(0, 0, canvas.width, canvas.height);
      data = ctx.getImageData(0, 0, canvas.width, canvas.height);
      var hiddenCanvas = document.createElement("canvas");
      hiddenCanvas.width = 28;
      hiddenCanvas.height = 28;
      var ctrx2 = hiddenCanvas.getContext("2d");
      if (ctrx2) {
        ctrx2.scale(0.125, 0.125);
        ctrx2.drawImage(canvas, 0, 0);
        data = ctrx2.getImageData(0, 0, 28, 28);
        await sendPrediction(data);
      }
    },
    false
  );
  canvas.addEventListener(
    "mouseout",
    function (e) {
      console.log("out");
      findxy("out", e, ctx);
    },
    false
  );
}

function scaleImageData(imageData: ImageData, scale: number) {
  var newCanvas = document.createElement("canvas");
  newCanvas.width = imageData.width;
  newCanvas.height = imageData.height;

  var ctxn = <CanvasRenderingContext2D>newCanvas.getContext("2d");
  ctxn.putImageData(imageData, 0, 0);

  // Second canvas, for scaling
  var scaleCanvas = document.createElement("canvas");
  scaleCanvas.width = imageData.width * scale;
  scaleCanvas.height = imageData.height * scale;

  var scaleCtx = <CanvasRenderingContext2D>scaleCanvas.getContext("2d");

  scaleCtx.scale(scale, scale);
  scaleCtx.drawImage(newCanvas, 0, 0);

  var scaledImageData = scaleCtx.getImageData(0, 0, scaleCanvas.width, scaleCanvas.height);

  return scaledImageData;
}

hub.on("receivePrediction", (digit: any, prediction: any) => {
  const displayDigit = <HTMLParagraphElement>document.getElementById("digit");
  const digits = <HTMLUListElement>document.getElementById("digits");
  if (!digits) return;
  if (!displayDigit) return;
  for (let i = 0; i < digits.children.length; i++) {
    const element = <HTMLSpanElement>digits.children[i].children[0];
    const score = prediction.score[i];
    //element.innerText = prediction.score[i];
    element.style.color = `rgb(${Math.floor(225 - score * 255)}, ${Math.floor(
      score * 255
    )}, 0, ${Math.floor(score * 255)})`;
  }
  digits.childNodes.item(0).childNodes[0];
  displayDigit.innerText = prediction.label;
});

hub.on("receiveBackground", (digits: any, prediction: any) => {
  backgroundDrawning(digits, prediction.label, prediction.score[prediction.label]);
});

function reset(): any {
  const canvas = <HTMLCanvasElement>document.getElementById("draw");
  const ctx = <CanvasRenderingContext2D>canvas.getContext("2d");
  ctx.clearRect(0, 0, canvas.width, canvas.height);
  const displayDigit = <HTMLParagraphElement>document.getElementById("digit");
  displayDigit.innerText = "";
  const digits = <HTMLUListElement>document.getElementById("digits");
  for (let i = 0; i < digits.children.length; i++) {
    const element = <HTMLSpanElement>digits.children[i].children[0];
    //element.innerText = prediction.score[i];
    element.style.color = `#000000`;
  }
}

async function sendPrediction(data: ImageData) {
  const result: Array<number> = [];
  data.data.forEach((v, i) => {
    if (i % 4 == 3) {
      result.push(v);
    }
  });
  hub.send("getPrediction", result);

  var destination = <HTMLCanvasElement>document.getElementById("destination");
  var ctxd = destination.getContext("2d");
  if (!ctxd) return;
  ctxd.putImageData(data, 0, 0);
}

(async () => {
  await hub.start();
  await setUpDrawning();
  var button = <HTMLButtonElement>document.getElementById("reset");
  button.onclick = reset;
})();
