"use strict";
var __awaiter = (this && this.__awaiter) || function (thisArg, _arguments, P, generator) {
    return new (P || (P = Promise))(function (resolve, reject) {
        function fulfilled(value) { try { step(generator.next(value)); } catch (e) { reject(e); } }
        function rejected(value) { try { step(generator["throw"](value)); } catch (e) { reject(e); } }
        function step(result) { result.done ? resolve(result.value) : new P(function (resolve) { resolve(result.value); }).then(fulfilled, rejected); }
        step((generator = generator.apply(thisArg, _arguments || [])).next());
    });
};
Object.defineProperty(exports, "__esModule", { value: true });
const signalr_1 = require("@aspnet/signalr");
var hub = new signalr_1.HubConnectionBuilder()
    .withUrl("http://www.google.com/hub")
    .configureLogging(signalr_1.LogLevel.Information)
    .build();
(() => __awaiter(this, void 0, void 0, function* () {
    //await hub.start();
    let c = document.getElementById("c");
    var ctx = c.getContext("2d");
    if (ctx) {
        ctx.fillStyle = "#FF0000";
        ctx.fillRect(20, 20, 150, 100);
        console.log('draw');
    }
}))();
