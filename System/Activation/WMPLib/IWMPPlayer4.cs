using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace WMPLib
{
	// Token: 0x0200000A RID: 10
	[CompilerGenerated]
	[Guid("6C497D62-8919-413C-82DB-E935FB3EC584")]
	[TypeIdentifier]
	[ComImport]
	public interface IWMPPlayer4 : IWMPCore3
	{
		// Token: 0x06000011 RID: 17
		void _VtblGap1_1();

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000012 RID: 18
		// (set) Token: 0x06000013 RID: 19
		[DispId(1)]
		string URL { [DispId(1)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(1)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] set; }

		// Token: 0x06000014 RID: 20
		void _VtblGap2_2();

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000015 RID: 21
		[DispId(4)]
		IWMPControls controls { [DispId(4)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }
	}
}
