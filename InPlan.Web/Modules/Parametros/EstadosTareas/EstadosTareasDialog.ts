import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { EstadosTareasForm, EstadosTareasRow, EstadosTareasService } from '../../ServerTypes/Parametros';

@Decorators.registerClass('InPlan.Parametros.EstadosTareasDialog')
export class EstadosTareasDialog extends EntityDialog<EstadosTareasRow, any> {
    protected getFormKey() { return EstadosTareasForm.formKey; }
    protected getRowDefinition() { return EstadosTareasRow; }
    protected getService() { return EstadosTareasService.baseUrl; }

    protected form = new EstadosTareasForm(this.idPrefix);
}