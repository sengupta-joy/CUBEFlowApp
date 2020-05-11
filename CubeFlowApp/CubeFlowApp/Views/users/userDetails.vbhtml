
@Code
    Layout = Nothing
    Dim UsersObj = ViewData("userObj")
    Dim i = 0
End Code


<div class="user-block user-block-x" title="@UsersObj.ID">
        <table border="0">
            <tr>
                <td rowspan="3"><img src="~/img/userImg/@(UsersObj.ID).jpg" onerror="loadDefaultImg(this);" /> </td>
                <td>
                    <input type="hidden" id="hdnID" value="@UsersObj.ID" />
                    <span class="usr-Name">@UsersObj.Name</span>
                </td>
            </tr>
            <tr>
                <td><div class="userDesig"></div></td>
            </tr>
            <tr>
                <td><div class="userDept"></div></td>
            </tr>
        </table>
    </div>
