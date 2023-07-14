import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { AreasForm, AreasRow, AreasService } from '../../ServerTypes/Tenencia';

@Decorators.registerClass('InPlan.Tenencia.AreasDialog')
export class AreasDialog extends EntityDialog<AreasRow, any> {
    protected getFormKey() { return AreasForm.formKey; }
    protected getRowDefinition() { return AreasRow; }
    protected getService() { return AreasService.baseUrl; }

    protected form = new AreasForm(this.idPrefix);
}