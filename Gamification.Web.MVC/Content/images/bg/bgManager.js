
var bgNumebr = Math.floor(Math.random() * 50) + 1;

var bgName = "";

if (bgNumebr < 10) {
    bgName = "bg0" + bgNumebr.toString();
} else {
    bgName = "bg" + bgNumebr.toString();
}

$(".page-content").addClass("custum-bg");
$(".page-content").addClass(bgName);