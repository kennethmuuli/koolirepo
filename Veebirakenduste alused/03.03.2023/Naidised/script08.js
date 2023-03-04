window.onload = initBannerLink;

var adImages = new Array("images/banner1.gif","images/banner2.gif","images/banner3.gif");
var adURL = new Array("hesburger.com","sun.com","microsoft.com");
var thisAd = 0;

function rotate() {
	thisAd++;
	if (thisAd == adImages.length) {// kui on ring täis, algab uuesti 0-ist
		thisAd = 0;
	}
	document.getElementById("adBanner").src = adImages[thisAd];

	setTimeout("rotate()", 3 * 1000);
}

function newLocation() {
	document.location.href = "http://www." + adURL[thisAd]; //lisatakse konkreetne URL aadress massiivist
	return false; 
}

function initBannerLink() {
	if (document.getElementById("adBanner").parentNode.tagName == "A") {  /* see kood initBannerLink()
	funktsioonis kontrollib, kas adBanner-objekt on seotud lingiga, kui on, siis klikkimisel käivitub
	newLocation() funktsioon,lõpuks käivitub rotate() funktsioon. */
		document.getElementById("adBanner").parentNode.onclick = newLocation;
	}
	
	rotate();
}
