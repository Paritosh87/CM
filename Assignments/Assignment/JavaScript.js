﻿String.prototype.startsWith = function (input) {
    return this.indexOf(input) == 0;
}

String.prototype.endsWith = function (input) {
    return this.substring(this.lastIndexOf(input)) === input;
}