
window.autoHeightTextarea = () => {
    const textarea = document.getElementsByTagName("textarea")[0];
        textarea.setAttribute("style", "height:" + (textarea.scrollHeight) + "px;overflow-y:hidden;");
        textarea.addEventListener("input", OnInput, false);
    
    function OnInput() {
        this.style.height = "auto";
        this.style.height = (this.scrollHeight) + "px";
    }
}

window.jsMethod = () => {
    var margin = 10,
        instance3 = new emojiButtonList("emojiButton", {
            dropDownXAlign: "center",
            dropDownYAlign: "top",
            textBoxID: "textMessage",
            yAlignMargin: margin,
            xAlignMargin: margin
        });
}


window.scrollToElementId = (elementId) => {
    console.info('scrolling to element', elementId);
    var element = document.getElementById(elementId);
    console.info('element', element);
    if (!element) {
        console.warn('element was not found', elementId);
    } else {
        element.scrollTop = element.scrollHeight;
    }
}
