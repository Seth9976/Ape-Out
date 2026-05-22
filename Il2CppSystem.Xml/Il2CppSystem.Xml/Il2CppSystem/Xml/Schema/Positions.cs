using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000109 RID: 265
	public class Positions : Object
	{
		// Token: 0x060015F7 RID: 5623 RVA: 0x000708C4 File Offset: 0x0006EAC4
		// Note: this type is marked as 'beforefieldinit'.
		static Positions()
		{
			Il2CppClassPointerStore<Positions>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "Positions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Positions>.NativeClassPtr);
			Positions.NativeFieldInfoPtr_positions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Positions>.NativeClassPtr, "positions");
			Positions.NativeMethodInfoPtr_Add_Public_Int32_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Positions>.NativeClassPtr, 100666609);
			Positions.NativeMethodInfoPtr_get_Item_Public_get_Position_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Positions>.NativeClassPtr, 100666610);
			Positions.NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Positions>.NativeClassPtr, 100666611);
			Positions.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Positions>.NativeClassPtr, 100666612);
		}

		// Token: 0x060015F8 RID: 5624 RVA: 0x00070958 File Offset: 0x0006EB58
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 409345, RefRangeEnd = 409349, XrefRangeStart = 409342, XrefRangeEnd = 409345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Add(int symbol, Object particle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref symbol;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(particle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Positions.NativeMethodInfoPtr_Add_Public_Int32_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000762 RID: 1890
		public unsafe Position this[int pos]
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 409351, RefRangeEnd = 409365, XrefRangeStart = 409349, XrefRangeEnd = 409351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref pos;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Positions.NativeMethodInfoPtr_get_Item_Public_get_Position_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new Position(intPtr);
				}
			}
		}

		// Token: 0x17000763 RID: 1891
		// (get) Token: 0x060015FA RID: 5626 RVA: 0x000709F8 File Offset: 0x0006EBF8
		public unsafe int Count
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Positions.NativeMethodInfoPtr_get_Count_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060015FB RID: 5627 RVA: 0x00070A34 File Offset: 0x0006EC34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 409365, XrefRangeEnd = 409369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Positions()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Positions>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Positions.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015FC RID: 5628 RVA: 0x00009D4F File Offset: 0x00007F4F
		public Positions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000761 RID: 1889
		// (get) Token: 0x060015FD RID: 5629 RVA: 0x00070A70 File Offset: 0x0006EC70
		// (set) Token: 0x060015FE RID: 5630 RVA: 0x00009D58 File Offset: 0x00007F58
		public unsafe ArrayList positions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Positions.NativeFieldInfoPtr_positions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Positions.NativeFieldInfoPtr_positions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040010BF RID: 4287
		private static readonly IntPtr NativeFieldInfoPtr_positions;

		// Token: 0x040010C0 RID: 4288
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Int32_Int32_Object_0;

		// Token: 0x040010C1 RID: 4289
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_Position_Int32_0;

		// Token: 0x040010C2 RID: 4290
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;

		// Token: 0x040010C3 RID: 4291
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
