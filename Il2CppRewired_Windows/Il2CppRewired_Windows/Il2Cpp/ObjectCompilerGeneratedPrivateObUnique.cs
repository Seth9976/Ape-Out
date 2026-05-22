using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2Cpp
{
	// Token: 0x020000B3 RID: 179
	[ObfuscatedName("<PrivateImplementationDetails>{E2215EBD-B39C-479A-A12B-BDD7898E067C}")]
	public class ObjectCompilerGeneratedPrivateObUnique : Object
	{
		// Token: 0x06000C31 RID: 3121 RVA: 0x0000728A File Offset: 0x0000548A
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectCompilerGeneratedPrivateObUnique()
		{
			Il2CppClassPointerStore<ObjectCompilerGeneratedPrivateObUnique>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Windows.dll", "", "<PrivateImplementationDetails>{E2215EBD-B39C-479A-A12B-BDD7898E067C}");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectCompilerGeneratedPrivateObUnique>.NativeClassPtr);
			ObjectCompilerGeneratedPrivateObUnique.NativeFieldInfoPtr_field_Internal_Static_ValueTypeNPrivateSealedUnique_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectCompilerGeneratedPrivateObUnique>.NativeClassPtr, "$$method0x6000793-1");
		}

		// Token: 0x06000C32 RID: 3122 RVA: 0x000072C3 File Offset: 0x000054C3
		public ObjectCompilerGeneratedPrivateObUnique(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x06000C33 RID: 3123 RVA: 0x000350A0 File Offset: 0x000332A0
		// (set) Token: 0x06000C34 RID: 3124 RVA: 0x000072CC File Offset: 0x000054CC
		public unsafe static ObjectCompilerGeneratedPrivateObUnique.ValueTypeNPrivateSealedUnique field_Internal_Static_ValueTypeNPrivateSealedUnique_0
		{
			get
			{
				ObjectCompilerGeneratedPrivateObUnique.ValueTypeNPrivateSealedUnique valueTypeNPrivateSealedUnique;
				IL2CPP.il2cpp_field_static_get_value(ObjectCompilerGeneratedPrivateObUnique.NativeFieldInfoPtr_field_Internal_Static_ValueTypeNPrivateSealedUnique_0, (void*)(&valueTypeNPrivateSealedUnique));
				return valueTypeNPrivateSealedUnique;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ObjectCompilerGeneratedPrivateObUnique.NativeFieldInfoPtr_field_Internal_Static_ValueTypeNPrivateSealedUnique_0, (void*)(&value));
			}
		}

		// Token: 0x04000B91 RID: 2961
		private static readonly IntPtr NativeFieldInfoPtr_field_Internal_Static_ValueTypeNPrivateSealedUnique_0;

		// Token: 0x0200011F RID: 287
		[ObfuscatedName("<PrivateImplementationDetails>{E2215EBD-B39C-479A-A12B-BDD7898E067C}+__StaticArrayInitTypeSize=88")]
		[StructLayout(2)]
		public struct ValueTypeNPrivateSealedUnique
		{
			// Token: 0x06001152 RID: 4434 RVA: 0x00009CDB File Offset: 0x00007EDB
			// Note: this type is marked as 'beforefieldinit'.
			static ValueTypeNPrivateSealedUnique()
			{
				Il2CppClassPointerStore<ObjectCompilerGeneratedPrivateObUnique.ValueTypeNPrivateSealedUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ObjectCompilerGeneratedPrivateObUnique>.NativeClassPtr, "__StaticArrayInitTypeSize=88");
			}

			// Token: 0x06001153 RID: 4435 RVA: 0x00009CF1 File Offset: 0x00007EF1
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ObjectCompilerGeneratedPrivateObUnique.ValueTypeNPrivateSealedUnique>.NativeClassPtr, ref this));
			}
		}
	}
}
