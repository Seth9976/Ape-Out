using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2Cpp
{
	// Token: 0x02000073 RID: 115
	[ObfuscatedName("<PrivateImplementationDetails>")]
	public sealed class _PrivateImplementationDetails_ : Object
	{
		// Token: 0x06000B22 RID: 2850 RVA: 0x00006001 File Offset: 0x00004201
		// Note: this type is marked as 'beforefieldinit'.
		static _PrivateImplementationDetails_()
		{
			Il2CppClassPointerStore<_PrivateImplementationDetails_>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "", "<PrivateImplementationDetails>");
			_PrivateImplementationDetails_.NativeFieldInfoPtr__1C3635C112D556F4C11A4FE6BDE6ED3F126C4B2B546811BDB64DE7BDED3A05CB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_PrivateImplementationDetails_>.NativeClassPtr, "1C3635C112D556F4C11A4FE6BDE6ED3F126C4B2B546811BDB64DE7BDED3A05CB");
		}

		// Token: 0x06000B23 RID: 2851 RVA: 0x00006030 File Offset: 0x00004230
		public _PrivateImplementationDetails_(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003BF RID: 959
		// (get) Token: 0x06000B24 RID: 2852 RVA: 0x00031B94 File Offset: 0x0002FD94
		// (set) Token: 0x06000B25 RID: 2853 RVA: 0x00006039 File Offset: 0x00004239
		public unsafe static _PrivateImplementationDetails_.ValueTypeNPrivateSealedUnique _1C3635C112D556F4C11A4FE6BDE6ED3F126C4B2B546811BDB64DE7BDED3A05CB
		{
			get
			{
				_PrivateImplementationDetails_.ValueTypeNPrivateSealedUnique valueTypeNPrivateSealedUnique;
				IL2CPP.il2cpp_field_static_get_value(_PrivateImplementationDetails_.NativeFieldInfoPtr__1C3635C112D556F4C11A4FE6BDE6ED3F126C4B2B546811BDB64DE7BDED3A05CB, (void*)(&valueTypeNPrivateSealedUnique));
				return valueTypeNPrivateSealedUnique;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(_PrivateImplementationDetails_.NativeFieldInfoPtr__1C3635C112D556F4C11A4FE6BDE6ED3F126C4B2B546811BDB64DE7BDED3A05CB, (void*)(&value));
			}
		}

		// Token: 0x04000869 RID: 2153
		private static readonly IntPtr NativeFieldInfoPtr__1C3635C112D556F4C11A4FE6BDE6ED3F126C4B2B546811BDB64DE7BDED3A05CB;

		// Token: 0x020000CF RID: 207
		[ObfuscatedName("<PrivateImplementationDetails>+__StaticArrayInitTypeSize=12")]
		[StructLayout(2)]
		public struct ValueTypeNPrivateSealedUnique
		{
			// Token: 0x06000CE4 RID: 3300 RVA: 0x00006E3D File Offset: 0x0000503D
			// Note: this type is marked as 'beforefieldinit'.
			static ValueTypeNPrivateSealedUnique()
			{
				Il2CppClassPointerStore<_PrivateImplementationDetails_.ValueTypeNPrivateSealedUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<_PrivateImplementationDetails_>.NativeClassPtr, "__StaticArrayInitTypeSize=12");
			}

			// Token: 0x06000CE5 RID: 3301 RVA: 0x00006E53 File Offset: 0x00005053
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<_PrivateImplementationDetails_.ValueTypeNPrivateSealedUnique>.NativeClassPtr, ref this));
			}
		}
	}
}
