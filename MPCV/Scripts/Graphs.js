var GraphHelper = function () {
};

GraphHelper.programmingSkills = function () {
    var graphdef = {
        categories: ["Programming skills"],
        dataset: {
            "Programming skills": [
                { name: "C#", value: 75 },
                { name: "Javascript", value: 55 },
                { name: "HTML", value: 50 },
                { name: "CSS", value: 45 }
            ]
        }
    };
    var chart = uv.chart("Bar", graphdef, {
            graph: {
                orientation: "Vertical"
            },
            effects: {
                hovercolor: "#2B4970",
                strokecolor: "none",
                textcolor: "#000000",
                duration: 600,
                hover: 200,
                showhovertext: false
            },
            dimension: {
                width: 700,
                height: 300
            },
            axis: {
                opacity: 0
            },
            tooltip: {
                show: false
            }
        }
    );
};