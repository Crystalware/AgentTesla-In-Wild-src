using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ADODB
{
	// Token: 0x0200002A RID: 42
	[CompilerGenerated]
	[Guid("0000054F-0000-0010-8000-00AA006D2EA4")]
	[DefaultMember("Fields")]
	[TypeIdentifier]
	[ComImport]
	public interface Recordset20 : Recordset15
	{
		// Token: 0x060002BB RID: 699
		void _VtblGap1_14();

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x060002BC RID: 700
		[DispId(0)]
		[IndexerName("Fields")]
		Fields Fields { [DispId(0)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }
	}
}
