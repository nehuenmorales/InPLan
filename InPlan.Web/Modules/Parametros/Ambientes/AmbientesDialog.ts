import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { AmbientesForm, AmbientesRow, AmbientesService } from '../../ServerTypes/Parametros';

@Decorators.registerClass('InPlan.Parametros.AmbientesDialog')
export class AmbientesDialog extends EntityDialog<AmbientesRow, any> {
    protected getFormKey() { return AmbientesForm.formKey; }
    protected getRowDefinition() { return AmbientesRow; }
    protected getService() { return AmbientesService.baseUrl; }

    protected form = new AmbientesForm(this.idPrefix);
}