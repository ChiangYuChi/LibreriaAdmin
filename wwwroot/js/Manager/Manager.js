﻿var managerAPP = new Vue({
    el: '#manager-index',
    data(){
        return {
            items: [],
            fields: [
                { key: 'managerID', label: 'ID', sortable: true, sortDirection: 'desc' },
                { key: 'managerName', label: '姓名', sortable: true, sortDirection: 'desc' },
                { key: 'managerRoleID', label: '管理者層級', sortable: true, sortDirection: 'desc' },
                { key: 'actions', label: '執行' },             

            ],
            totalRows: 1,
            currentPage: 1,
            perPage: 20,
            pageOptions: [5, 10, 15, { value: 100, text: "Show a lot" }],
            sortBy: '',
            sortDesc: false,
            sortDirection: 'asc',
            filter: null,
            filterOn: []
        }
        
    },
    created: function () {
        axios.get("/api/Manager/GetAllManagers")
            .then((res) => {
                this.items = res.data.body.managerList;
            });
    },
    computed: {
        sortOptions() {
            // Create an options list from our fields
            return this.fields
                .filter(f => f.sortable)
                .map(f => {
                    return { text: f.label, value: f.key }
                })
        }
    },
    mounted() {
        // Set the initial number of items
        this.totalRows = this.items.length
    },
    methods: {

        resetInfoModal() {
            this.infoModal.title = ''
            this.infoModal.content = ''
        },
        onFiltered(filteredItems) {
            // Trigger pagination to update the number of buttons/pages due to filtering
            this.totalRows = filteredItems.length
            this.currentPage = 1
        },
        removeItem: function (item) {
            let backendApi = "https://localhost:5001/api/Product/DeleteItem";
            let result = document.getElementById("result");
            
            console.log(item);
            //axios.delete("/api/Product/DeleteItem")
            //    .then((res) => {
            //        console.log(res);
            //  })
            if ((item != null || item != '') && item > 0) {
                document.getElementById("apiUrl").innerText = "BackendAPI URL : " + backendApi;
                let request = {ProductId: item}
                $.ajax({
                    url: backendApi,
                    method: "POST",
                    dataType: "json",   //如果有JSON回傳資料, 則加上此行, 若無請勿加, 會引起parse error
                    data: JSON.stringify(request),
                    contentType: "application/json;charset=UTF-8",   
                    success: function (data, textStatus, jqXHR) {
                        console.log(data);
                        console.log(textStatus);
                        console.log(jqXHR.status);
                        console.log(jqXHR.getAllResponseHeaders());
                        if (jqXHR.status == "202") {
                            result.innerText = `${item}資料刪除成功!`;
                        }
                    },
                    error: function (jqXHR, textStatus, errorThrown) {
                        result.innerText = textStatus + ", " + jqXHR.status;
                    }
                })

            }

        }        
    }
});