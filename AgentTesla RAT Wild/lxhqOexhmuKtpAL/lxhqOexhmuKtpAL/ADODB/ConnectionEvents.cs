using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ADODB
{
	// Token: 0x0200001D RID: 29
	[CompilerGenerated]
	[InterfaceType(2)]
	[DefaultMember("InfoMessage")]
	[Guid("00000400-0000-0010-8000-00AA006D2EA4")]
	[TypeIdentifier]
	[ComImport]
	public interface ConnectionEvents
	{
		// Token: 0x060002AA RID: 682
		[DispId(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void InfoMessage([MarshalAs(UnmanagedType.Interface)] [In] Error pError, [In] [Out] ref EventStatusEnum adStatus, [MarshalAs(UnmanagedType.Interface)] [In] Connection pConnection);
	}
}
