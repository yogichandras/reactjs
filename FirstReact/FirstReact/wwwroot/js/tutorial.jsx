var CommentList = React.createClass({
    render: function () {
        return (
            <div className="commentList">
                <Comment author="Daniel Lo Nigro">Hello ReactJS.NET World!</Comment>
                <Comment author="Pete Hunt">This is one comment</Comment>
     
      </div>
        );
    }
});


var Comment = React.createClass({
    render: function () {
        return (
            <div className="comment">
                <h2 className="commentAuthor">
                    {this.props.author}
                </h2>
                {this.props.children}
            </div>
        );
    }
});


var CommentForm = React.createClass({
    render: function () {
        return (
            <div className="CommentForm">
               Hello World! I'am The Man Who Can't Be Moved!
            </div>
        );
    }
});

var CommentBox = React.createClass({
    render: function () {
        return (
            <div className="commentBox">
                <h1>Comments</h1>
                <CommentList />
                <CommentForm />
            </div>
        );
    }
});

ReactDOM.render(
    <CommentBox />,
    document.getElementById('content')
);