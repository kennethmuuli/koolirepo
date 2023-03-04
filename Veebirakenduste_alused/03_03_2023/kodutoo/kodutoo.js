window.onload = initLinks;

var myPix = new Array(
	"images/slideImg0",
	"images/slideImg1",
	"images/slideImg2",
	"images/slideImg3",
	"images/slideImg4",
	);
var thisPic = 0;

function initLinks() {  // see funktsioon loob event handlerid Previous ja Next linkidele
	document.getElementById("prevLink").onclick = processPrevious;
	document.getElementById("nextLink").onclick = processNext;
}

function processPrevious() {  // see funktsioon paneb slideshow jooksma previous suunal
	if (thisPic == 0) {
		thisPic = myPix.length;
	}
	thisPic--;  // vähendab thisPic väärtust 1. võrra
	document.getElementById("myPicture").src = myPix[thisPic];// src myPicture seotakse myPix massiivi konkreetse väärtusega thisPic (myPicture==id)
	return false;
}

function processNext() {  //slideshow jookseb next suunas
	thisPic++;
	if (thisPic == myPix.length) {
		thisPic = 0;
	}
	document.getElementById("myPicture").src = myPix[thisPic];
	return false;
}
