import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { TiposImplementacionForm, TiposImplementacionRow, TiposImplementacionService } from '../../ServerTypes/Implementacion';

@Decorators.registerClass('InPlan.Implementacion.TiposImplementacionDialog')
export class TiposImplementacionDialog extends EntityDialog<TiposImplementacionRow, any> {
    protected getFormKey() { return TiposImplementacionForm.formKey; }
    protected getRowDefinition() { return TiposImplementacionRow; }
    protected getService() { return TiposImplementacionService.baseUrl; }

    protected form = new TiposImplementacionForm(this.idPrefix);
}