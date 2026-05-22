using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppTMPro
{
	// Token: 0x0200006A RID: 106
	[StructLayout(2)]
	public struct Extents
	{
		// Token: 0x06000C74 RID: 3188 RVA: 0x0003465C File Offset: 0x0003285C
		// Note: this type is marked as 'beforefieldinit'.
		static Extents()
		{
			Il2CppClassPointerStore<Extents>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "Extents");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Extents>.NativeClassPtr);
			Extents.NativeFieldInfoPtr_zero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Extents>.NativeClassPtr, "zero");
			Extents.NativeFieldInfoPtr_uninitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Extents>.NativeClassPtr, "uninitialized");
			Extents.NativeFieldInfoPtr_min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Extents>.NativeClassPtr, "min");
			Extents.NativeFieldInfoPtr_max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Extents>.NativeClassPtr, "max");
			Extents.NativeMethodInfoPtr__ctor_Public_Void_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Extents>.NativeClassPtr, 100664710);
			Extents.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Extents>.NativeClassPtr, 100664711);
		}

		// Token: 0x06000C75 RID: 3189 RVA: 0x00034704 File Offset: 0x00032904
		[CallerCount(0)]
		public unsafe Extents(Vector2 min, Vector2 max)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref min;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Extents.NativeMethodInfoPtr__ctor_Public_Void_Vector2_Vector2_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C76 RID: 3190 RVA: 0x00034744 File Offset: 0x00032944
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464527, XrefRangeEnd = 464602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Extents.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000C77 RID: 3191 RVA: 0x00007C6E File Offset: 0x00005E6E
		public global::Il2CppSystem.Object BoxIl2CppObject()
		{
			return new global::Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Extents>.NativeClassPtr, ref this));
		}

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x06000C78 RID: 3192 RVA: 0x00034770 File Offset: 0x00032970
		// (set) Token: 0x06000C79 RID: 3193 RVA: 0x00007C80 File Offset: 0x00005E80
		public unsafe static Extents zero
		{
			get
			{
				Extents extents;
				IL2CPP.il2cpp_field_static_get_value(Extents.NativeFieldInfoPtr_zero, (void*)(&extents));
				return extents;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Extents.NativeFieldInfoPtr_zero, (void*)(&value));
			}
		}

		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x06000C7A RID: 3194 RVA: 0x0003478C File Offset: 0x0003298C
		// (set) Token: 0x06000C7B RID: 3195 RVA: 0x00007C8E File Offset: 0x00005E8E
		public unsafe static Extents uninitialized
		{
			get
			{
				Extents extents;
				IL2CPP.il2cpp_field_static_get_value(Extents.NativeFieldInfoPtr_uninitialized, (void*)(&extents));
				return extents;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Extents.NativeFieldInfoPtr_uninitialized, (void*)(&value));
			}
		}

		// Token: 0x040009FC RID: 2556
		private static readonly IntPtr NativeFieldInfoPtr_zero;

		// Token: 0x040009FD RID: 2557
		private static readonly IntPtr NativeFieldInfoPtr_uninitialized;

		// Token: 0x040009FE RID: 2558
		private static readonly IntPtr NativeFieldInfoPtr_min;

		// Token: 0x040009FF RID: 2559
		private static readonly IntPtr NativeFieldInfoPtr_max;

		// Token: 0x04000A00 RID: 2560
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector2_Vector2_0;

		// Token: 0x04000A01 RID: 2561
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000A02 RID: 2562
		[FieldOffset(0)]
		public Vector2 min;

		// Token: 0x04000A03 RID: 2563
		[FieldOffset(8)]
		public Vector2 max;
	}
}
