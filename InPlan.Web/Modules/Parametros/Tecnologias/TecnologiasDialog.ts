import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { TecnologiasForm, TecnologiasRow, TecnologiasService } from '../../ServerTypes/Parametros';

@Decorators.registerClass('InPlan.Parametros.TecnologiasDialog')
export class TecnologiasDialog extends EntityDialog<TecnologiasRow, any> {
    protected getFormKey() { return TecnologiasForm.formKey; }
    protected getRowDefinition() { return TecnologiasRow; }
    protected getService() { return TecnologiasService.baseUrl; }

    protected form = new TecnologiasForm(this.idPrefix);
}