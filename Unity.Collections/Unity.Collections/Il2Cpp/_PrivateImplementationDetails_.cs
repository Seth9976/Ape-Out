using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2Cpp
{
	// Token: 0x02000033 RID: 51
	[ObfuscatedName("<PrivateImplementationDetails>")]
	public sealed class _PrivateImplementationDetails_ : Object
	{
		// Token: 0x060001FA RID: 506 RVA: 0x00002AD0 File Offset: 0x00000CD0
		// Note: this type is marked as 'beforefieldinit'.
		static _PrivateImplementationDetails_()
		{
			Il2CppClassPointerStore<_PrivateImplementationDetails_>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Collections.dll", "", "<PrivateImplementationDetails>");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_PrivateImplementationDetails_>.NativeClassPtr);
			_PrivateImplementationDetails_.NativeFieldInfoPtr__2CF2F88BF9B71283059B6DF53E5BCDE20ADBFD9E8D6CE2C1AB106262BB283BED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_PrivateImplementationDetails_>.NativeClassPtr, "2CF2F88BF9B71283059B6DF53E5BCDE20ADBFD9E8D6CE2C1AB106262BB283BED");
		}

		// Token: 0x060001FB RID: 507 RVA: 0x00002B09 File Offset: 0x00000D09
		public _PrivateImplementationDetails_(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060001FC RID: 508 RVA: 0x0000DE0C File Offset: 0x0000C00C
		// (set) Token: 0x060001FD RID: 509 RVA: 0x00002B12 File Offset: 0x00000D12
		public unsafe static _PrivateImplementationDetails_.ValueTypeNPrivateSealedUnique _2CF2F88BF9B71283059B6DF53E5BCDE20ADBFD9E8D6CE2C1AB106262BB283BED
		{
			get
			{
				_PrivateImplementationDetails_.ValueTypeNPrivateSealedUnique valueTypeNPrivateSealedUnique;
				IL2CPP.il2cpp_field_static_get_value(_PrivateImplementationDetails_.NativeFieldInfoPtr__2CF2F88BF9B71283059B6DF53E5BCDE20ADBFD9E8D6CE2C1AB106262BB283BED, (void*)(&valueTypeNPrivateSealedUnique));
				return valueTypeNPrivateSealedUnique;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(_PrivateImplementationDetails_.NativeFieldInfoPtr__2CF2F88BF9B71283059B6DF53E5BCDE20ADBFD9E8D6CE2C1AB106262BB283BED, (void*)(&value));
			}
		}

		// Token: 0x0400048B RID: 1163
		private static readonly IntPtr NativeFieldInfoPtr__2CF2F88BF9B71283059B6DF53E5BCDE20ADBFD9E8D6CE2C1AB106262BB283BED;

		// Token: 0x02000062 RID: 98
		[ObfuscatedName("<PrivateImplementationDetails>+__StaticArrayInitTypeSize=192")]
		[StructLayout(2)]
		public struct ValueTypeNPrivateSealedUnique
		{
			// Token: 0x0600031E RID: 798 RVA: 0x00003568 File Offset: 0x00001768
			// Note: this type is marked as 'beforefieldinit'.
			static ValueTypeNPrivateSealedUnique()
			{
				Il2CppClassPointerStore<_PrivateImplementationDetails_.ValueTypeNPrivateSealedUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<_PrivateImplementationDetails_>.NativeClassPtr, "__StaticArrayInitTypeSize=192");
			}

			// Token: 0x0600031F RID: 799 RVA: 0x0000357E File Offset: 0x0000177E
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<_PrivateImplementationDetails_.ValueTypeNPrivateSealedUnique>.NativeClassPtr, ref this));
			}
		}
	}
}
