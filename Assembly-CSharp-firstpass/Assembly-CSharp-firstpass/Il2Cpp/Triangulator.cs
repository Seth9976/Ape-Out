using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000004 RID: 4
	public class Triangulator : global::Il2CppSystem.Object
	{
		// Token: 0x0600000E RID: 14 RVA: 0x0000E08C File Offset: 0x0000C28C
		// Note: this type is marked as 'beforefieldinit'.
		static Triangulator()
		{
			Il2CppClassPointerStore<Triangulator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "Triangulator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Triangulator>.NativeClassPtr);
			Triangulator.NativeFieldInfoPtr_m_points = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Triangulator>.NativeClassPtr, "m_points");
			Triangulator.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Triangulator>.NativeClassPtr, 100663305);
			Triangulator.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Triangulator>.NativeClassPtr, 100663306);
			Triangulator.NativeMethodInfoPtr_Triangulate_Public_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Triangulator>.NativeClassPtr, 100663307);
			Triangulator.NativeMethodInfoPtr_Area_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Triangulator>.NativeClassPtr, 100663308);
			Triangulator.NativeMethodInfoPtr_Snip_Private_Boolean_Int32_Int32_Int32_Int32_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Triangulator>.NativeClassPtr, 100663309);
			Triangulator.NativeMethodInfoPtr_InsideTriangle_Private_Boolean_Vector2_Vector2_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Triangulator>.NativeClassPtr, 100663310);
		}

		// Token: 0x0600000F RID: 15 RVA: 0x0000E148 File Offset: 0x0000C348
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 146, RefRangeEnd = 150, XrefRangeStart = 136, XrefRangeEnd = 146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Triangulator(Il2CppStructArray<Vector2> points)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Triangulator>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(points);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Triangulator.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000010 RID: 16 RVA: 0x0000E194 File Offset: 0x0000C394
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 162, RefRangeEnd = 164, XrefRangeStart = 150, XrefRangeEnd = 162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Triangulator(Il2CppStructArray<Vector3> points)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Triangulator>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(points);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Triangulator.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000011 RID: 17 RVA: 0x0000E1E0 File Offset: 0x0000C3E0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 206, RefRangeEnd = 212, XrefRangeStart = 164, XrefRangeEnd = 206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<int> Triangulate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Triangulator.NativeMethodInfoPtr_Triangulate_Public_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x0000E220 File Offset: 0x0000C420
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212, XrefRangeEnd = 214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float Area()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Triangulator.NativeMethodInfoPtr_Area_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x0000E25C File Offset: 0x0000C45C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 219, RefRangeEnd = 220, XrefRangeStart = 214, XrefRangeEnd = 219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Snip(int u, int v, int w, int n, Il2CppStructArray<int> V)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref u;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref v;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref w;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref n;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(V);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Triangulator.NativeMethodInfoPtr_Snip_Private_Boolean_Int32_Int32_Int32_Int32_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x0000E2E4 File Offset: 0x0000C4E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 221, RefRangeEnd = 222, XrefRangeStart = 220, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool InsideTriangle(Vector2 A, Vector2 B, Vector2 C, Vector2 P)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref B;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref C;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref P;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Triangulator.NativeMethodInfoPtr_InsideTriangle_Private_Boolean_Vector2_Vector2_Vector2_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002062 File Offset: 0x00000262
		public Triangulator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000016 RID: 22 RVA: 0x0000E358 File Offset: 0x0000C558
		// (set) Token: 0x06000017 RID: 23 RVA: 0x0000206B File Offset: 0x0000026B
		public unsafe List<Vector2> m_points
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Triangulator.NativeFieldInfoPtr_m_points);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Triangulator.NativeFieldInfoPtr_m_points), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000009 RID: 9
		private static readonly IntPtr NativeFieldInfoPtr_m_points;

		// Token: 0x0400000A RID: 10
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Vector2_0;

		// Token: 0x0400000B RID: 11
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Vector3_0;

		// Token: 0x0400000C RID: 12
		private static readonly IntPtr NativeMethodInfoPtr_Triangulate_Public_Il2CppStructArray_1_Int32_0;

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr NativeMethodInfoPtr_Area_Private_Single_0;

		// Token: 0x0400000E RID: 14
		private static readonly IntPtr NativeMethodInfoPtr_Snip_Private_Boolean_Int32_Int32_Int32_Int32_Il2CppStructArray_1_Int32_0;

		// Token: 0x0400000F RID: 15
		private static readonly IntPtr NativeMethodInfoPtr_InsideTriangle_Private_Boolean_Vector2_Vector2_Vector2_Vector2_0;
	}
}
