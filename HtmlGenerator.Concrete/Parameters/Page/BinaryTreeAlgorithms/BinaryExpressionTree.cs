﻿using HtmlGenerator.Abstractions.Interfaces;
using HtmlGenerator.Routes.Route;

namespace HtmlGenerator.Concrete.Parameters.Page.BinaryTreeAlgorithms
{
    public class BinaryExpressionTree : IPageParameter
    {
        public string DirectoryName => Path.BinaryTreeAlgorithms.ExpressionTree;
        public string SubTitle => Path.BinaryTreeAlgorithms.ExpressionTree;
        public string SnippetPath => Snippet.BtAlgorithms.ExpressionTree;
        public string Description => Routes.Route.Description.BinaryTreeAlgorithms.ExpressionTree;
    }
}