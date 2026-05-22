using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Il2CppCodeStage.AntiCheat.Utils
{
	// Token: 0x020001F5 RID: 501
	public class xxHash : Object
	{
		// Token: 0x06001998 RID: 6552 RVA: 0x00073F84 File Offset: 0x00072184
		// Note: this type is marked as 'beforefieldinit'.
		static xxHash()
		{
			Il2CppClassPointerStore<xxHash>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CodeStage.AntiCheat.Utils", "xxHash");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<xxHash>.NativeClassPtr);
			xxHash.NativeFieldInfoPtr_PRIME32_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<xxHash>.NativeClassPtr, "PRIME32_1");
			xxHash.NativeFieldInfoPtr_PRIME32_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<xxHash>.NativeClassPtr, "PRIME32_2");
			xxHash.NativeFieldInfoPtr_PRIME32_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<xxHash>.NativeClassPtr, "PRIME32_3");
			xxHash.NativeFieldInfoPtr_PRIME32_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<xxHash>.NativeClassPtr, "PRIME32_4");
			xxHash.NativeFieldInfoPtr_PRIME32_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<xxHash>.NativeClassPtr, "PRIME32_5");
			xxHash.NativeMethodInfoPtr_CalculateHash_Public_Static_UInt32_Il2CppStructArray_1_Byte_Int32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<xxHash>.NativeClassPtr, 100667326);
			xxHash.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<xxHash>.NativeClassPtr, 100667327);
		}

		// Token: 0x06001999 RID: 6553 RVA: 0x00074040 File Offset: 0x00072240
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 22754, RefRangeEnd = 22757, XrefRangeStart = 22753, XrefRangeEnd = 22754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint CalculateHash(Il2CppStructArray<byte> buf, int len, uint seed)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buf);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref seed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(xxHash.NativeMethodInfoPtr_CalculateHash_Public_Static_UInt32_Il2CppStructArray_1_Byte_Int32_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600199A RID: 6554 RVA: 0x000740A0 File Offset: 0x000722A0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe xxHash()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<xxHash>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(xxHash.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600199B RID: 6555 RVA: 0x00009F67 File Offset: 0x00008167
		public xxHash(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700054D RID: 1357
		// (get) Token: 0x0600199C RID: 6556 RVA: 0x000740DC File Offset: 0x000722DC
		// (set) Token: 0x0600199D RID: 6557 RVA: 0x00009F70 File Offset: 0x00008170
		public unsafe static uint PRIME32_1
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(xxHash.NativeFieldInfoPtr_PRIME32_1, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(xxHash.NativeFieldInfoPtr_PRIME32_1, (void*)(&value));
			}
		}

		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x0600199E RID: 6558 RVA: 0x000740F8 File Offset: 0x000722F8
		// (set) Token: 0x0600199F RID: 6559 RVA: 0x00009F7E File Offset: 0x0000817E
		public unsafe static uint PRIME32_2
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(xxHash.NativeFieldInfoPtr_PRIME32_2, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(xxHash.NativeFieldInfoPtr_PRIME32_2, (void*)(&value));
			}
		}

		// Token: 0x1700054F RID: 1359
		// (get) Token: 0x060019A0 RID: 6560 RVA: 0x00074114 File Offset: 0x00072314
		// (set) Token: 0x060019A1 RID: 6561 RVA: 0x00009F8C File Offset: 0x0000818C
		public unsafe static uint PRIME32_3
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(xxHash.NativeFieldInfoPtr_PRIME32_3, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(xxHash.NativeFieldInfoPtr_PRIME32_3, (void*)(&value));
			}
		}

		// Token: 0x17000550 RID: 1360
		// (get) Token: 0x060019A2 RID: 6562 RVA: 0x00074130 File Offset: 0x00072330
		// (set) Token: 0x060019A3 RID: 6563 RVA: 0x00009F9A File Offset: 0x0000819A
		public unsafe static uint PRIME32_4
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(xxHash.NativeFieldInfoPtr_PRIME32_4, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(xxHash.NativeFieldInfoPtr_PRIME32_4, (void*)(&value));
			}
		}

		// Token: 0x17000551 RID: 1361
		// (get) Token: 0x060019A4 RID: 6564 RVA: 0x0007414C File Offset: 0x0007234C
		// (set) Token: 0x060019A5 RID: 6565 RVA: 0x00009FA8 File Offset: 0x000081A8
		public unsafe static uint PRIME32_5
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(xxHash.NativeFieldInfoPtr_PRIME32_5, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(xxHash.NativeFieldInfoPtr_PRIME32_5, (void*)(&value));
			}
		}

		// Token: 0x04001A7E RID: 6782
		private static readonly IntPtr NativeFieldInfoPtr_PRIME32_1;

		// Token: 0x04001A7F RID: 6783
		private static readonly IntPtr NativeFieldInfoPtr_PRIME32_2;

		// Token: 0x04001A80 RID: 6784
		private static readonly IntPtr NativeFieldInfoPtr_PRIME32_3;

		// Token: 0x04001A81 RID: 6785
		private static readonly IntPtr NativeFieldInfoPtr_PRIME32_4;

		// Token: 0x04001A82 RID: 6786
		private static readonly IntPtr NativeFieldInfoPtr_PRIME32_5;

		// Token: 0x04001A83 RID: 6787
		private static readonly IntPtr NativeMethodInfoPtr_CalculateHash_Public_Static_UInt32_Il2CppStructArray_1_Byte_Int32_UInt32_0;

		// Token: 0x04001A84 RID: 6788
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
