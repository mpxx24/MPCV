"use strict";
var Assistant = (function () {
    function Assistant(configuration) {
        this.configuration = configuration;
        this.initializeView();
        this.initilaizeControls();
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
        }, 40);
    };
    ;
    Assistant.prototype.showYesNoButtons = function () {
        var _this = this;
        var yesButton = $(HtmlControlsHelper.HtmlButton("yes"));
        var noButton = $(HtmlControlsHelper.HtmlButton("no"));
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
        var ulWithOptions = HtmlControlsHelper.HtmlUl(2, ["option1", "option2"]);
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
        //$(`#${this.configuration.InfoLinkId}`).click(this.infoLinkClicked.bind(this));
        $("#" + this.configuration.InfoLinkId).show();
    };
    ;
    Assistant.prototype.initilaizeControls = function () {
        $("#" + this.configuration.InfoLinkId).click(this.onAssistantInfoLinkClicked.bind(this));
    };
    Assistant.prototype.onAssistantInfoLinkClicked = function () {
        var _this = this;
        console.log("CLICKS");
        $.ajax({
            url: this.configuration.AssistantModalContentData,
            type: "GET",
            dataType: "text",
            success: function (result) {
                $("#" + _this.configuration.AssistantModalContentDivId + " > p").text(result);
            }
        });
    };
    ;
    return Assistant;
}());
//# sourceMappingURL=Assistant.js.map