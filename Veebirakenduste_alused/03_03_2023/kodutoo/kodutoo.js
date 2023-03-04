window.onload = initLinks;

var myImages = new Array(
	"images/slideImg0.jpg",
	"images/slideImg1.jpg",
	"images/slideImg2.jpg",
	"images/slideImg3.jpg",
	"images/slideImg4.jpg",
	);
var currentImage = 0;

//order matched with myImages order, if you change order of images in myImages OR add/remove images, make sure to update descriptions accordingly
var imageDescriptions = new Array(
	"This is a cruise ship",
	"This is a river between mountains",
	"This is a beautiful mountain",
	"This might be Rose Dewitt Bukaters ring, the one she threw in the ocean.",
	"This is a shabby house",
);
var currentDescription = 0;

var randomNumber;

function initLinks() {
	
	generateRandom();
	
	document.getElementById("image").src = myImages[currentImage]
	document.getElementById("imageDescription").innerHTML = imageDescriptions[currentDescription];

	document.getElementById("generate").onclick = generateRandom;
}

function generateRandom() {
	randomNumber = Math.floor(Math.random() * myImages.length);

	loadImage();
}

function loadImage() { 

	currentImage = randomNumber;
	currentDescription = randomNumber;

	document.getElementById("image").src = myImages[currentImage]
	document.getElementById("imageDescription").innerHTML = imageDescriptions[currentDescription];

	return false;
}

