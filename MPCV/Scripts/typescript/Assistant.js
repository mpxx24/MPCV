var Assistant = (function () {
    function Assistant(configuration) {
        this.configuration = configuration;
        this.initializeView();
        this.initializeAssistant();
        this.initializeAssistantsActions();
    }
    Assistant.prototype.initializeView = function () {
    };
    ;
    Assistant.prototype.initializeAssistant = function () {
        this.textBubbleDiv = $("#" + this.configuration.TalkBubbleId + " > p");
    };
    ;
    Assistant.prototype.initializeAssistantsActions = function () {
        this.sayLetterByLetter("Hi, welcome at " + document.title + " view. Do you need any help?");
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
                _this.showYesNoButtons();
                _this.showAssistantInfoLink();
            }
        }, 50);
    };
    ;
    Assistant.prototype.showYesNoButtons = function () {
        var _this = this;
        var yesButton = $('<input type="button" value="Yes"/>');
        var noButton = $('<input type="button" value="No"/>');
        yesButton.on("click", function () { _this.onYesHelpButtonClicked(); });
        noButton.on("click", function () { _this.onNoHelpButtonClicked(); });
        $("#" + this.configuration.AssistantId).append(yesButton);
        $("#" + this.configuration.AssistantId).append(noButton);
    };
    ;
    Assistant.prototype.setTextBubbleText = function (message) {
        this.textBubbleDiv.text(message);
    };
    ;
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
        this.setTextBubbleText("");
        var ulWithOptions = "<ul>\n            <li><a href=\"http://google.pl\">google</a>\n            <li><a href=\"http://reddit.com\">reddit</a>\n            </ul>";
        this.textBubbleDiv.append(ulWithOptions);
    };
    ;
    Assistant.prototype.onNoHelpButtonClicked = function () {
        alert("NO WAS CLICKED");
    };
    ;
    Assistant.prototype.showAssistanInfo = function () {
        alert("INFORMATIONS");
    };
    ;
    Assistant.prototype.showAssistantInfoLink = function () {
        $("#" + this.configuration.InfoLinkId).click(this.infoLinkClicked.bind(this));
        $("#" + this.configuration.InfoLinkId).show();
    };
    ;
    Assistant.prototype.infoLinkClicked = function () {
        alert("test info click");
    };
    ;
    return Assistant;
}());
