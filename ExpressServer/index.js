const express = require('express');
const path = require('path');
const cors = require('cors');
const bodyParser = require('body-parser');
const fs = require('fs');
const { json } = require('body-parser');

const app = express();
const port = process.env.PORT || 8000;
const options = {
    root: path.join(__dirname)
}

app.use(cors());
app.use(bodyParser.urlencoded({ extended: false }))
app.use(bodyParser());

app.post('/store-user', (req, res) => {
    console.log("POST request received ", req.body);
    const currentUser = req.body;
    const rawData = fs.readFileSync(path.join(__dirname, 'users.json'));
    const jsonData = JSON.parse(rawData);   
    jsonData.Users.forEach(user => {
        if(user.Email === currentUser.Email && user.Password === currentUser.Password) {
            user.ReservedDorms = currentUser.ReservedDorms;
        }
    });
    console.log(jsonData);
    let data = JSON.stringify(jsonData, null, 2);
    fs.writeFileSync(path.join(__dirname, 'users.json'), data);
    res.send(200);
});

app.get('/users', (req, res) => { 
    res.sendFile('users.json', options);
});

app.get('/dorms', (req, res) => {
    res.sendFile('dorms.json', options);
});

app.get('/test', (req, res) => {
    res.json({passed: true});
})

app.listen(port, () => {
    console.log(`Listening on port ${port}`);
});