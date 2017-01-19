var Assistant = (function () {
    function Assistant(configuration) {
        this.configuration = configuration;
        this.initializeAssistant();
        this.initializeAssistantsActions();
    }
    Assistant.prototype.initializeAssistant = function () {
        this.textBubbleDiv = $("#" + this.configuration.TalkBubbleId);
    };
    ;
    Assistant.prototype.initializeAssistantsActions = function () {
        var _this = this;
        this.sayLetterByLetter("Hi, welcome at " + document.title + " view. Do you need any help?");
        var yesButton = $('<input type="button" value="Yes"/>');
        var noButton = $('<input type="button" value="No"/>');
        yesButton.on("click", function () { _this.onYesHelpButtonClicked(); });
        noButton.on("click", function () { _this.onNoHelpButtonClicked(); });
        $("#" + this.configuration.AssistantId).append(yesButton);
        $("#" + this.configuration.AssistantId).append(noButton);
    };
    ;
    Assistant.prototype.sayLetterByLetter = function (message) {
        var _this = this;
        var letters = message.split("");
        var index = 0;
        this.textBubbleDiv.text("");
        var interval = setInterval(function () {
            if (_this.textBubbleDiv.text().length < message.length) {
                _this.setTextBubbleText(_this.textBubbleDiv.text() + letters[index]);
                index++;
            }
            else {
                clearInterval(interval);
            }
        }, 50);
    };
    Assistant.prototype.setTextBubbleText = function (message) {
        this.textBubbleDiv.text(message);
    };
    Assistant.prototype.setQuestionsFlowForCurrentSite = function () {
    };
    ;
    Assistant.prototype.getAnswerFromTheServer = function () {
    };
    ;
    Assistant.prototype.customContextMenuActions = function () {
    };
    ;
    Assistant.prototype.onYesHelpButtonClicked = function () {
        alert("YES WAS CLICKED");
    };
    Assistant.prototype.onNoHelpButtonClicked = function () {
        alert("NO WAS CLICKED");
    };
    return Assistant;
}());
