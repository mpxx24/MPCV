var HtmlControlsHelper = (function () {
    function HtmlControlsHelper() {
    }
    HtmlControlsHelper.HtmlButton = function (buttonText) {
        return "<input type=\"button\" value=\"" + buttonText + "\"/>";
    };
    HtmlControlsHelper.HtmlUl = function (numberOfLiElements, names) {
        var ulBeginning = "<ul>";
        if (numberOfLiElements !== names.length) {
            return "";
        }
        for (var i = 0; i < numberOfLiElements; i++) {
            ulBeginning += "<li>" + names[i] + "</li>";
        }
        ulBeginning += "</ul>";
        return ulBeginning;
    };
    return HtmlControlsHelper;
}());
//# sourceMappingURL=HtmlControlsHelper.js.map