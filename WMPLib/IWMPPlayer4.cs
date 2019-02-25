using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace WMPLib
{
	[ComImport]
	[CompilerGenerated]
	[Guid("6C497D62-8919-413C-82DB-E935FB3EC584")]
	[TypeIdentifier]
	public interface IWMPPlayer4 : IWMPCore3
	{
		[DispId(1)]
		string URL
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			[DispId(1)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall)]
			[DispId(1)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(4)]
		IWMPControls controls
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			[DispId(4)]
			[return: MarshalAs(UnmanagedType.Interface)]
			get;
		}

		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(3)]
		void close();

		void _VtblGap1_2();
	}
}