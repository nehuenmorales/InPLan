import { Decorators } from "@serenity-is/corelib";
import { GridEditorBase } from "@serenity-is/extensions";
import { alert, alertDialog, toId, tryFirst } from "@serenity-is/corelib/q";
import { DetalleImplementacionesColumns, DetalleImplementacionesRow } from "../../ServerTypes/Implementacion";
import { DetalleImplementacionesDialogEditor } from "./DetalleImplementacionesDialogEditor";

@Decorators.registerEditor("InPlan.Colaboradores.DetalleImplementacionesEditor")
export class DetalleImplementacionesEditor extends GridEditorBase<DetalleImplementacionesRow> {
    protected getColumnsKey() { return DetalleImplementacionesColumns.columnsKey; }
    protected getDialogType() { return DetalleImplementacionesDialogEditor; }
    protected getLocalTextPrefix() { return DetalleImplementacionesRow.localTextPrefix; }


    constructor(container: JQuery) {
        super(container);
    }

    protected validateEntity(row: DetalleImplementacionesRow, id: number) {
        //row.IdCodPostal = toId(row.IdCodPostal)

        //var sameCodPostal = tryFirst(this.view.getItems(), x => x.IdCodPostal == row.IdCodPostal)
        //if (sameCodPostal && this.id(sameCodPostal) !== id) {
        //    if (sameCodPostal.Altura.toLocaleLowerCase() == row.Altura.toLocaleLowerCase() &&
        //        sameCodPostal.Calle.toLocaleLowerCase() == row.Calle.toLocaleLowerCase()) {
        //        alertDialog("La dirección ya esta registrada")
        //        return false
        //        }
        //}

        //id ??= row[this.getIdProperty()]



        //    CodigosPostalesRow.getLookupAsync()
        //        .then(loockup => {
        //            var item = this.view?.getItemById?.(id);
        //            if (item) {
        //                item.IdCodPostalCodPostal = loockup.itemById[row.IdCodPostal].CodPostal
        //                this.view.updateItem(id, item)
        //            }
        //        })

        //    return true;
        //}

        return true
    }

}