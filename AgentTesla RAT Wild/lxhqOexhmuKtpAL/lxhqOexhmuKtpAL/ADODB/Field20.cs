using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ADODB
{
	// Token: 0x02000022 RID: 34
	[CompilerGenerated]
	[DefaultMember("Value")]
	[Guid("00000569-0000-0010-8000-00AA006D2EA4")]
	[TypeIdentifier]
	[ComImport]
	public interface Field : Field20
	{
		// Token: 0x060002AD RID: 685
		void _VtblGap1_6();

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x060002AE RID: 686
		// (set) Token: 0x060002AF RID: 687
		[DispId(0)]
		[IndexerName("Value")]
		object Value { [DispId(0)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Struct)] get; [DispId(0)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.Struct)] [param: In] set; }
	}
}
