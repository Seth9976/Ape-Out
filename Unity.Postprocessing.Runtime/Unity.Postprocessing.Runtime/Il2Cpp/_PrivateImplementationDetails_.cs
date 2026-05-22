using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2Cpp
{
	// Token: 0x02000067 RID: 103
	[ObfuscatedName("<PrivateImplementationDetails>")]
	public sealed class _PrivateImplementationDetails_ : Object
	{
		// Token: 0x060006C6 RID: 1734 RVA: 0x000055E6 File Offset: 0x000037E6
		// Note: this type is marked as 'beforefieldinit'.
		static _PrivateImplementationDetails_()
		{
			Il2CppClassPointerStore<_PrivateImplementationDetails_>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Postprocessing.Runtime.dll", "", "<PrivateImplementationDetails>");
			_PrivateImplementationDetails_.NativeFieldInfoPtr_BEE794DBCD4CBBBF1C7DAF41EF192F0C8543F2C04DCD5D88F445D71BB75FC08A = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_PrivateImplementationDetails_>.NativeClassPtr, "BEE794DBCD4CBBBF1C7DAF41EF192F0C8543F2C04DCD5D88F445D71BB75FC08A");
		}

		// Token: 0x060006C7 RID: 1735 RVA: 0x00005615 File Offset: 0x00003815
		public _PrivateImplementationDetails_(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x060006C8 RID: 1736 RVA: 0x0001A768 File Offset: 0x00018968
		// (set) Token: 0x060006C9 RID: 1737 RVA: 0x0000561E File Offset: 0x0000381E
		public unsafe static _PrivateImplementationDetails_.ValueTypeNPrivateSealedUnique BEE794DBCD4CBBBF1C7DAF41EF192F0C8543F2C04DCD5D88F445D71BB75FC08A
		{
			get
			{
				_PrivateImplementationDetails_.ValueTypeNPrivateSealedUnique valueTypeNPrivateSealedUnique;
				IL2CPP.il2cpp_field_static_get_value(_PrivateImplementationDetails_.NativeFieldInfoPtr_BEE794DBCD4CBBBF1C7DAF41EF192F0C8543F2C04DCD5D88F445D71BB75FC08A, (void*)(&valueTypeNPrivateSealedUnique));
				return valueTypeNPrivateSealedUnique;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(_PrivateImplementationDetails_.NativeFieldInfoPtr_BEE794DBCD4CBBBF1C7DAF41EF192F0C8543F2C04DCD5D88F445D71BB75FC08A, (void*)(&value));
			}
		}

		// Token: 0x04000463 RID: 1123
		private static readonly IntPtr NativeFieldInfoPtr_BEE794DBCD4CBBBF1C7DAF41EF192F0C8543F2C04DCD5D88F445D71BB75FC08A;

		// Token: 0x0200009D RID: 157
		[ObfuscatedName("<PrivateImplementationDetails>+__StaticArrayInitTypeSize=20")]
		[StructLayout(2)]
		public struct ValueTypeNPrivateSealedUnique
		{
			// Token: 0x060007D6 RID: 2006 RVA: 0x00005F9B File Offset: 0x0000419B
			// Note: this type is marked as 'beforefieldinit'.
			static ValueTypeNPrivateSealedUnique()
			{
				Il2CppClassPointerStore<_PrivateImplementationDetails_.ValueTypeNPrivateSealedUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<_PrivateImplementationDetails_>.NativeClassPtr, "__StaticArrayInitTypeSize=20");
			}

			// Token: 0x060007D7 RID: 2007 RVA: 0x00005FB1 File Offset: 0x000041B1
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<_PrivateImplementationDetails_.ValueTypeNPrivateSealedUnique>.NativeClassPtr, ref this));
			}
		}
	}
}
