window.onload = choosePic;

var myPix = new Array("images/lion.jpg","images/tiger.jpg","images/bear.jpg");

function choosePic() {
	randomNum = Math.floor((Math.random() * myPix.length));
	document.getElementById("myPicture").src = myPix[randomNum];
}
