import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { TiposImplementacionGrid } from './TiposImplementacionGrid';

export default function pageInit() {
    initFullHeightGridPage(new TiposImplementacionGrid($('#GridDiv')).element);
}