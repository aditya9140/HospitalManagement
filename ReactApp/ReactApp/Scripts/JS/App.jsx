﻿var Hello = React.createClass({
    render: function () {
        return (
            <div>Hello World</div>
        );
    }
});
React.render(<Hello/>,document.getElementById("reactdiv"));