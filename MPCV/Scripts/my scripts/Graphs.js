var GraphHelper = function() {
};

GraphHelper.programmingSkills = function() {
    $.ajax({
        url: "SkillsForGraph",
        type: "post",
        dataType: "json",
        contentType: "application/json",
        success: function (result) {
            var data = JSON.stringify(result.ProgrammingSkills);

            var graphdef = {
                categories: ["ProgrammingSkills"],
                dataset: {
                    "ProgrammingSkills": JSON.parse(data)
                }
            };

            uv.chart('Bar', graphdef, {
                graph: {
                    orientation: "Horizontal"
                },
                effects: {
                    hovercolor: "#2B4970",
                    strokecolor: "none",
                    textcolor: "#000000",
                    duration: 500,
                    hover: 200,
                    showhovertext: true
                },
                dimension: {
                    width: 400,
                    height: 100
                },
                axis: {
                    opacity: 0,
                    showtext: true,
                    strokecolor: "none",
                    ticks: 0
                },
                tooltip: {
                    show: true
                },
                legend: {
                    showlegends: false
                }
            });
        },
        error: function () {
            alert("Couldn't get the data!");
        }
    });
};

