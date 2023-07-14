import { Decorators } from '@serenity-is/corelib';
import { GridEditorDialog } from "@serenity-is/extensions";
import { DetalleImplementacionesForm, DetalleImplementacionesRow, DetalleImplementacionesService } from '../../ServerTypes/Implementacion';

@Decorators.registerClass('InPlan.Colaboradores.DetalleImplementacionesDialogEditor')
export class DetalleImplementacionesDialogEditor extends GridEditorDialog<DetalleImplementacionesRow> {
    protected getFormKey() { return DetalleImplementacionesForm.formKey; }
    protected getRowDefinition() { return DetalleImplementacionesRow; }
    protected getService() { return DetalleImplementacionesService.baseUrl; }

    protected form = new DetalleImplementacionesForm(this.idPrefix);
}