
window.jsMethod = () => {
    var margin = 10,
        instance3 = new emojiButtonList("button3", {
            dropDownXAlign: "center",
            dropDownYAlign: "top",
            textBoxID: "text3",
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
