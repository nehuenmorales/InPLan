import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { ProyectosTecnologiasColumns, ProyectosTecnologiasRow, ProyectosTecnologiasService } from '../../ServerTypes/Parametros';
import { ProyectosTecnologiasDialog } from './ProyectosTecnologiasDialog';

@Decorators.registerClass('InPlan.Parametros.ProyectosTecnologiasGrid')
export class ProyectosTecnologiasGrid extends EntityGrid<ProyectosTecnologiasRow, any> {
    protected getColumnsKey() { return ProyectosTecnologiasColumns.columnsKey; }
    protected getDialogType() { return ProyectosTecnologiasDialog; }
    protected getRowDefinition() { return ProyectosTecnologiasRow; }
    protected getService() { return ProyectosTecnologiasService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}