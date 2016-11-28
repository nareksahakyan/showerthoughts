
document.getElementById("myForm").onsubmit = function () {
    var data = CKEDITOR.instances.editor1.getData();
    var elem = document.getElementById("editor1");
    elem.setAttribute("value", data);
}

//$("#myclick").onsubmit = getxontent();


//function getxontent() {

//    var list = document.getElementsByClassName("cke_editable cke_editable_themed cke_contents_ltr cke_show_borders");
//    var tmp = list[0].textContent;

//}

