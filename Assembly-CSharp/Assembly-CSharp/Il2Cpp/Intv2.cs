using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2Cpp
{
	// Token: 0x02000156 RID: 342
	[Serializable]
	[StructLayout(2)]
	public struct Intv2
	{
		// Token: 0x0600292D RID: 10541 RVA: 0x000A62AC File Offset: 0x000A44AC
		// Note: this type is marked as 'beforefieldinit'.
		static Intv2()
		{
			Il2CppClassPointerStore<Intv2>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Intv2");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Intv2>.NativeClassPtr);
			Intv2.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Intv2>.NativeClassPtr, "x");
			Intv2.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Intv2>.NativeClassPtr, "y");
			Intv2.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Intv2>.NativeClassPtr, 100666559);
		}

		// Token: 0x0600292E RID: 10542 RVA: 0x000A6318 File Offset: 0x000A4518
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 76853, RefRangeEnd = 76855, XrefRangeStart = 76853, XrefRangeEnd = 76853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Intv2(int _x, int _y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref _x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Intv2.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600292F RID: 10543 RVA: 0x0001CB24 File Offset: 0x0001AD24
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Intv2>.NativeClassPtr, ref this));
		}

		// Token: 0x0400183B RID: 6203
		private static readonly IntPtr NativeFieldInfoPtr_x;

		// Token: 0x0400183C RID: 6204
		private static readonly IntPtr NativeFieldInfoPtr_y;

		// Token: 0x0400183D RID: 6205
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;

		// Token: 0x0400183E RID: 6206
		[FieldOffset(0)]
		public int x;

		// Token: 0x0400183F RID: 6207
		[FieldOffset(4)]
		public int y;
	}
}
