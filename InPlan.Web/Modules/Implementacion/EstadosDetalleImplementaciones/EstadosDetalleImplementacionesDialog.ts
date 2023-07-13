import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { EstadosDetalleImplementacionesForm, EstadosDetalleImplementacionesRow, EstadosDetalleImplementacionesService } from '../../ServerTypes/Implementacion';

@Decorators.registerClass('InPlan.Implementacion.EstadosDetalleImplementacionesDialog')
export class EstadosDetalleImplementacionesDialog extends EntityDialog<EstadosDetalleImplementacionesRow, any> {
    protected getFormKey() { return EstadosDetalleImplementacionesForm.formKey; }
    protected getRowDefinition() { return EstadosDetalleImplementacionesRow; }
    protected getService() { return EstadosDetalleImplementacionesService.baseUrl; }

    protected form = new EstadosDetalleImplementacionesForm(this.idPrefix);
}