



<div class="user-block user-block-x" title="@Model.key">
    <table border="0">
        <tr>
            <td rowspan="3"><img src="~/img/userImg/@(Model.key).jpg" onerror="loadDefaultImg(this);" /> </td>
            <td>
                <input type="hidden" id="hdnID" value="@Model.key" />
                <span class="usr-Name">@Model.value</span>
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
