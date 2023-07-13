import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { TecnicosForm, TecnicosRow, TecnicosService } from '../../ServerTypes/Parametros';

@Decorators.registerClass('InPlan.Parametros.TecnicosDialog')
export class TecnicosDialog extends EntityDialog<TecnicosRow, any> {
    protected getFormKey() { return TecnicosForm.formKey; }
    protected getRowDefinition() { return TecnicosRow; }
    protected getService() { return TecnicosService.baseUrl; }

    protected form = new TecnicosForm(this.idPrefix);
}