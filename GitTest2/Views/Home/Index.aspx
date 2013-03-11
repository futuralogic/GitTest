<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<IEnumerable<Beer>>" %>
<%@ Import Namespace="GitTest2" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title></title>
</head>
<body style="background-color:#000000;color:#ffffff">
	<div>
		<%= Html.Encode(ViewData["Message"]) %>
	</div>
	Beers:<br/>
	<ul>
	<% foreach( var drink in Model.OrderBy( o=>o.Rating ) ) { %>
		<li><% =drink.Name %> = <% =drink.AlcoholPercent %> (<%=drink.Rating%>)</li>
	<% } %>
	</ul>
</body>

