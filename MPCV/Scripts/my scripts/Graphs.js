var GraphHelper = function() {
};

GraphHelper.programmingSkills = function() {
    var graphdef = {
        categories: ["Programming skills"],
        dataset: {
            "Programming skills": [
                { name: "C#", value: 75 },
                { name: "Javascript", value: 55 },
                { name: "jQuery", value: 50 },
                { name: "HTML", value: 65 },
                { name: "CSS", value: 45 }
            ]
        }
    };
    var chart = uv.chart("Bar", graphdef, {
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
        }
    );
};