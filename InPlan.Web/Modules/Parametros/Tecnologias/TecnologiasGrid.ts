import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { TecnologiasColumns, TecnologiasRow, TecnologiasService } from '../../ServerTypes/Parametros';
import { TecnologiasDialog } from './TecnologiasDialog';

@Decorators.registerClass('InPlan.Parametros.TecnologiasGrid')
export class TecnologiasGrid extends EntityGrid<TecnologiasRow, any> {
    protected getColumnsKey() { return TecnologiasColumns.columnsKey; }
    protected getDialogType() { return TecnologiasDialog; }
    protected getRowDefinition() { return TecnologiasRow; }
    protected getService() { return TecnologiasService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}