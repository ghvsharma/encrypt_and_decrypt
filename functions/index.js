const crypto = require('crypto');
const { stringify } = require('querystring');
exports.handler = function(context, event, callback) {

var Data=event.paymentobj;

let collectData = JSON.stringify(Data);
var key = "XNopKZ@$TiMBf64tZ9eg~RiaQSZ#Pw%*";
var encrypted = encrypt(collectData, key);
console.log(encrypted);
callback(null, encrypted);
};



function encrypt (text, key) {
try {
const IV_LENGTH = 16; // For AES, this is always 16
let iv = crypto.randomBytes(IV_LENGTH);
let cipher = crypto.createCipheriv('aes-256-cbc', Buffer.from(key), iv);
let encrypted = cipher.update(text);
encrypted = Buffer.concat([encrypted, cipher.final()]);

return iv.toString('hex') + ':' + encrypted.toString('hex');
} catch (err) {
throw err;
}
}