const Cryptr = require('cryptr');
const cryptr = new Cryptr('vOVH7sdmpMPjUSIqDc5rdxs02lwHzfr9');
 
const encryptedString = cryptr.encrypt('bacon');
const decryptedString = cryptr.decrypt('9c5328d2911308b73d8d8bb7d8b6aa27069af5a9b4bb4b7c60b57c036b67ef9c9c4816f9c9e4934f2d7d6c625f274b636cb46223da09b22306643e706abf0ff3ee028dc6815d8365a99ca80348c89f5d9ea6c27030ddaeb128792bb6e21c9d513b17571d8a');

console.log(encryptedString);
console.log(decryptedString);
