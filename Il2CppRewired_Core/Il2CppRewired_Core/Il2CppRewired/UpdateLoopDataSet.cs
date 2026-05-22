using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppRewired.Config;
using Il2CppSystem;

namespace Il2CppRewired
{
	// Token: 0x02000028 RID: 40
	public class UpdateLoopDataSet<T> : Object where T : class
	{
		// Token: 0x06000319 RID: 793 RVA: 0x00039A1C File Offset: 0x00037C1C
		// Note: this type is marked as 'beforefieldinit'.
		static UpdateLoopDataSet()
		{
			Il2CppClassPointerStore<UpdateLoopDataSet<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired", "UpdateLoopDataSet`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdateLoopDataSet<T>>.NativeClassPtr);
			UpdateLoopDataSet<T>.NativeFieldInfoPtr_jNzAQZTQMNNBGiaNVTMLyZVENuv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateLoopDataSet<T>>.NativeClassPtr, "jNzAQZTQMNNBGiaNVTMLyZVENuv");
			UpdateLoopDataSet<T>.NativeFieldInfoPtr_zmCdukpeIKvQzFPInjjecrTRBZH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateLoopDataSet<T>>.NativeClassPtr, "zmCdukpeIKvQzFPInjjecrTRBZH");
			UpdateLoopDataSet<T>.NativeFieldInfoPtr_BpUQZGuJErUHxYEClmgxzKolRCu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateLoopDataSet<T>>.NativeClassPtr, "BpUQZGuJErUHxYEClmgxzKolRCu");
			UpdateLoopDataSet<T>.NativeFieldInfoPtr_fixedUpdateSetIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateLoopDataSet<T>>.NativeClassPtr, "fixedUpdateSetIndex");
			UpdateLoopDataSet<T>.NativeFieldInfoPtr_UNhrDlHVHupYurOqDONrxjcNRWM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateLoopDataSet<T>>.NativeClassPtr, "UNhrDlHVHupYurOqDONrxjcNRWM");
			UpdateLoopDataSet<T>.NativeFieldInfoPtr_TEGEJPNAqxfgdHefkYSMunfknzI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateLoopDataSet<T>>.NativeClassPtr, "TEGEJPNAqxfgdHefkYSMunfknzI");
			UpdateLoopDataSet<T>.NativeFieldInfoPtr_VpVBPWqAVmCzlyOcYUnsspEhQqE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateLoopDataSet<T>>.NativeClassPtr, "VpVBPWqAVmCzlyOcYUnsspEhQqE");
			UpdateLoopDataSet<T>.NativeMethodInfoPtr_get_Current_Public_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateLoopDataSet<T>>.NativeClassPtr, 100663803);
			UpdateLoopDataSet<T>.NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateLoopDataSet<T>>.NativeClassPtr, 100663804);
			UpdateLoopDataSet<T>.NativeMethodInfoPtr_get_Item_Public_get_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateLoopDataSet<T>>.NativeClassPtr, 100663805);
			UpdateLoopDataSet<T>.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateLoopDataSet<T>>.NativeClassPtr, 100663806);
			UpdateLoopDataSet<T>.NativeMethodInfoPtr__ctor_Public_Void_UpdateLoopSetting_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateLoopDataSet<T>>.NativeClassPtr, 100663807);
			UpdateLoopDataSet<T>.NativeMethodInfoPtr__ctor_Public_Void_UpdateLoopSetting_Func_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateLoopDataSet<T>>.NativeClassPtr, 100663808);
			UpdateLoopDataSet<T>.NativeMethodInfoPtr_SetUpdateLoop_Public_Void_UpdateLoopType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateLoopDataSet<T>>.NativeClassPtr, 100663809);
			UpdateLoopDataSet<T>.NativeMethodInfoPtr_Get_Public_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateLoopDataSet<T>>.NativeClassPtr, 100663810);
			UpdateLoopDataSet<T>.NativeMethodInfoPtr_Get_Public_T_UpdateLoopType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateLoopDataSet<T>>.NativeClassPtr, 100663811);
			UpdateLoopDataSet<T>.NativeMethodInfoPtr_Set_Public_Void_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateLoopDataSet<T>>.NativeClassPtr, 100663812);
			UpdateLoopDataSet<T>.NativeMethodInfoPtr_GetUpdateLoopType_Public_UpdateLoopType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateLoopDataSet<T>>.NativeClassPtr, 100663813);
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x0600031A RID: 794 RVA: 0x00039BF0 File Offset: 0x00037DF0
		public unsafe T Current
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UpdateLoopDataSet<T>.NativeMethodInfoPtr_get_Current_Public_get_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x0600031B RID: 795 RVA: 0x00039C2C File Offset: 0x00037E2C
		public unsafe int Count
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UpdateLoopDataSet<T>.NativeMethodInfoPtr_get_Count_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000100 RID: 256
		public unsafe T this[int index]
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 244387, RefRangeEnd = 244401, XrefRangeStart = 244387, XrefRangeEnd = 244387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UpdateLoopDataSet<T>.NativeMethodInfoPtr_get_Item_Public_get_T_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
				}
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 244410, RefRangeEnd = 244412, XrefRangeStart = 244401, XrefRangeEnd = 244410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
				}
				IntPtr* ptr2 = ptr + checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
				ref T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t = value;
					if (!(t is string))
					{
						ref T ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
						if ((ref ptr3) != null)
						{
							ptr4 = ref ptr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
							{
								ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
							}
						}
					}
					else
					{
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
					}
				}
				else
				{
					ptr4 = ref value;
				}
				*ptr2 = ref ptr4;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UpdateLoopDataSet<T>.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600031E RID: 798 RVA: 0x00039D4C File Offset: 0x00037F4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UpdateLoopDataSet(UpdateLoopSetting updateLoops)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UpdateLoopDataSet<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref updateLoops;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UpdateLoopDataSet<T>.NativeMethodInfoPtr__ctor_Public_Void_UpdateLoopSetting_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600031F RID: 799 RVA: 0x00039D94 File Offset: 0x00037F94
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 244450, RefRangeEnd = 244452, XrefRangeStart = 244412, XrefRangeEnd = 244450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UpdateLoopDataSet(UpdateLoopSetting updateLoops, Func<T> instantiatorDelegate)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UpdateLoopDataSet<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref updateLoops;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instantiatorDelegate);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UpdateLoopDataSet<T>.NativeMethodInfoPtr__ctor_Public_Void_UpdateLoopSetting_Func_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000320 RID: 800 RVA: 0x00039DF0 File Offset: 0x00037FF0
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 244452, RefRangeEnd = 244464, XrefRangeStart = 244452, XrefRangeEnd = 244452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetUpdateLoop(UpdateLoopType updateLoop)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref updateLoop;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UpdateLoopDataSet<T>.NativeMethodInfoPtr_SetUpdateLoop_Public_Void_UpdateLoopType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000321 RID: 801 RVA: 0x00039E30 File Offset: 0x00038030
		[CallerCount(0)]
		public unsafe T Get(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UpdateLoopDataSet<T>.NativeMethodInfoPtr_Get_Public_T_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06000322 RID: 802 RVA: 0x00039E78 File Offset: 0x00038078
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 244464, RefRangeEnd = 244468, XrefRangeStart = 244464, XrefRangeEnd = 244464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T Get(UpdateLoopType updateLoop)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref updateLoop;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UpdateLoopDataSet<T>.NativeMethodInfoPtr_Get_Public_T_UpdateLoopType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06000323 RID: 803 RVA: 0x00039EC0 File Offset: 0x000380C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244468, XrefRangeEnd = 244477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Set(int index, T item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			IntPtr* ptr2 = ptr + checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
			ref T ptr4;
			if (!typeof(T).IsValueType)
			{
				T t = item;
				if (!(t is string))
				{
					ref T ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					if ((ref ptr3) != null)
					{
						ptr4 = ref ptr3;
						if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
						{
							ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
						}
					}
				}
				else
				{
					ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
				}
			}
			else
			{
				ptr4 = ref item;
			}
			*ptr2 = ref ptr4;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UpdateLoopDataSet<T>.NativeMethodInfoPtr_Set_Public_Void_Int32_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000324 RID: 804 RVA: 0x00039F5C File Offset: 0x0003815C
		[CallerCount(0)]
		public unsafe UpdateLoopType GetUpdateLoopType(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UpdateLoopDataSet<T>.NativeMethodInfoPtr_GetUpdateLoopType_Public_UpdateLoopType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000325 RID: 805 RVA: 0x00003029 File Offset: 0x00001229
		public UpdateLoopDataSet(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x06000326 RID: 806 RVA: 0x00039FA8 File Offset: 0x000381A8
		// (set) Token: 0x06000327 RID: 807 RVA: 0x00003032 File Offset: 0x00001232
		public unsafe static int jNzAQZTQMNNBGiaNVTMLyZVENuv
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(UpdateLoopDataSet<T>.NativeFieldInfoPtr_jNzAQZTQMNNBGiaNVTMLyZVENuv, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UpdateLoopDataSet<T>.NativeFieldInfoPtr_jNzAQZTQMNNBGiaNVTMLyZVENuv, (void*)(&value));
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x06000328 RID: 808 RVA: 0x00039FC4 File Offset: 0x000381C4
		// (set) Token: 0x06000329 RID: 809 RVA: 0x00003040 File Offset: 0x00001240
		public unsafe UpdateLoopDataSet<T>.zVJapvtWtEllziTivnvetEmjFKP zmCdukpeIKvQzFPInjjecrTRBZH
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateLoopDataSet<T>.NativeFieldInfoPtr_zmCdukpeIKvQzFPInjjecrTRBZH);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UpdateLoopDataSet<T>.zVJapvtWtEllziTivnvetEmjFKP>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateLoopDataSet<T>.NativeFieldInfoPtr_zmCdukpeIKvQzFPInjjecrTRBZH), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x0600032A RID: 810 RVA: 0x00039FF4 File Offset: 0x000381F4
		// (set) Token: 0x0600032B RID: 811 RVA: 0x0000305F File Offset: 0x0000125F
		public unsafe int BpUQZGuJErUHxYEClmgxzKolRCu
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateLoopDataSet<T>.NativeFieldInfoPtr_BpUQZGuJErUHxYEClmgxzKolRCu);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateLoopDataSet<T>.NativeFieldInfoPtr_BpUQZGuJErUHxYEClmgxzKolRCu)) = value;
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x0600032C RID: 812 RVA: 0x0003A01C File Offset: 0x0003821C
		// (set) Token: 0x0600032D RID: 813 RVA: 0x0000307A File Offset: 0x0000127A
		public unsafe int fixedUpdateSetIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateLoopDataSet<T>.NativeFieldInfoPtr_fixedUpdateSetIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateLoopDataSet<T>.NativeFieldInfoPtr_fixedUpdateSetIndex)) = value;
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x0600032E RID: 814 RVA: 0x0003A044 File Offset: 0x00038244
		// (set) Token: 0x0600032F RID: 815 RVA: 0x00003095 File Offset: 0x00001295
		public unsafe Il2CppStructArray<int> UNhrDlHVHupYurOqDONrxjcNRWM
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateLoopDataSet<T>.NativeFieldInfoPtr_UNhrDlHVHupYurOqDONrxjcNRWM);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateLoopDataSet<T>.NativeFieldInfoPtr_UNhrDlHVHupYurOqDONrxjcNRWM), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x06000330 RID: 816 RVA: 0x0003A074 File Offset: 0x00038274
		// (set) Token: 0x06000331 RID: 817 RVA: 0x000030B4 File Offset: 0x000012B4
		public unsafe Il2CppReferenceArray<UpdateLoopDataSet<T>.zVJapvtWtEllziTivnvetEmjFKP> TEGEJPNAqxfgdHefkYSMunfknzI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateLoopDataSet<T>.NativeFieldInfoPtr_TEGEJPNAqxfgdHefkYSMunfknzI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<UpdateLoopDataSet<T>.zVJapvtWtEllziTivnvetEmjFKP>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateLoopDataSet<T>.NativeFieldInfoPtr_TEGEJPNAqxfgdHefkYSMunfknzI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x06000332 RID: 818 RVA: 0x0003A0A4 File Offset: 0x000382A4
		// (set) Token: 0x06000333 RID: 819 RVA: 0x000030D3 File Offset: 0x000012D3
		public unsafe UpdateLoopType VpVBPWqAVmCzlyOcYUnsspEhQqE
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateLoopDataSet<T>.NativeFieldInfoPtr_VpVBPWqAVmCzlyOcYUnsspEhQqE);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateLoopDataSet<T>.NativeFieldInfoPtr_VpVBPWqAVmCzlyOcYUnsspEhQqE)) = value;
			}
		}

		// Token: 0x0400029F RID: 671
		private static readonly IntPtr NativeFieldInfoPtr_jNzAQZTQMNNBGiaNVTMLyZVENuv;

		// Token: 0x040002A0 RID: 672
		private static readonly IntPtr NativeFieldInfoPtr_zmCdukpeIKvQzFPInjjecrTRBZH;

		// Token: 0x040002A1 RID: 673
		private static readonly IntPtr NativeFieldInfoPtr_BpUQZGuJErUHxYEClmgxzKolRCu;

		// Token: 0x040002A2 RID: 674
		private static readonly IntPtr NativeFieldInfoPtr_fixedUpdateSetIndex;

		// Token: 0x040002A3 RID: 675
		private static readonly IntPtr NativeFieldInfoPtr_UNhrDlHVHupYurOqDONrxjcNRWM;

		// Token: 0x040002A4 RID: 676
		private static readonly IntPtr NativeFieldInfoPtr_TEGEJPNAqxfgdHefkYSMunfknzI;

		// Token: 0x040002A5 RID: 677
		private static readonly IntPtr NativeFieldInfoPtr_VpVBPWqAVmCzlyOcYUnsspEhQqE;

		// Token: 0x040002A6 RID: 678
		private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_get_T_0;

		// Token: 0x040002A7 RID: 679
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;

		// Token: 0x040002A8 RID: 680
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_T_Int32_0;

		// Token: 0x040002A9 RID: 681
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_T_0;

		// Token: 0x040002AA RID: 682
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UpdateLoopSetting_0;

		// Token: 0x040002AB RID: 683
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UpdateLoopSetting_Func_1_T_0;

		// Token: 0x040002AC RID: 684
		private static readonly IntPtr NativeMethodInfoPtr_SetUpdateLoop_Public_Void_UpdateLoopType_0;

		// Token: 0x040002AD RID: 685
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_T_Int32_0;

		// Token: 0x040002AE RID: 686
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_T_UpdateLoopType_0;

		// Token: 0x040002AF RID: 687
		private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Void_Int32_T_0;

		// Token: 0x040002B0 RID: 688
		private static readonly IntPtr NativeMethodInfoPtr_GetUpdateLoopType_Public_UpdateLoopType_Int32_0;

		// Token: 0x02000234 RID: 564
		public class zVJapvtWtEllziTivnvetEmjFKP : Object
		{
			// Token: 0x06003818 RID: 14360 RVA: 0x00113B10 File Offset: 0x00111D10
			// Note: this type is marked as 'beforefieldinit'.
			static zVJapvtWtEllziTivnvetEmjFKP()
			{
				Il2CppClassPointerStore<UpdateLoopDataSet<T>.zVJapvtWtEllziTivnvetEmjFKP>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UpdateLoopDataSet<T>>.NativeClassPtr, "zVJapvtWtEllziTivnvetEmjFKP"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdateLoopDataSet<T>.zVJapvtWtEllziTivnvetEmjFKP>.NativeClassPtr);
				UpdateLoopDataSet<T>.zVJapvtWtEllziTivnvetEmjFKP.NativeFieldInfoPtr_HmLJOEaFHWwVymwfHWYgZGnwyFG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateLoopDataSet<T>.zVJapvtWtEllziTivnvetEmjFKP>.NativeClassPtr, "HmLJOEaFHWwVymwfHWYgZGnwyFG");
				UpdateLoopDataSet<T>.zVJapvtWtEllziTivnvetEmjFKP.NativeFieldInfoPtr_lNPPGsBAWvbWdCjtDTNnwnbOjQw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateLoopDataSet<T>.zVJapvtWtEllziTivnvetEmjFKP>.NativeClassPtr, "lNPPGsBAWvbWdCjtDTNnwnbOjQw");
				UpdateLoopDataSet<T>.zVJapvtWtEllziTivnvetEmjFKP.NativeMethodInfoPtr__ctor_Public_Void_UpdateLoopType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateLoopDataSet<T>.zVJapvtWtEllziTivnvetEmjFKP>.NativeClassPtr, 100663814);
			}

			// Token: 0x06003819 RID: 14361 RVA: 0x00113BB4 File Offset: 0x00111DB4
			[CallerCount(0)]
			public unsafe zVJapvtWtEllziTivnvetEmjFKP(UpdateLoopType updateLoop)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UpdateLoopDataSet<T>.zVJapvtWtEllziTivnvetEmjFKP>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref updateLoop;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UpdateLoopDataSet<T>.zVJapvtWtEllziTivnvetEmjFKP.NativeMethodInfoPtr__ctor_Public_Void_UpdateLoopType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600381A RID: 14362 RVA: 0x00013659 File Offset: 0x00011859
			public zVJapvtWtEllziTivnvetEmjFKP(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170010B8 RID: 4280
			// (get) Token: 0x0600381B RID: 14363 RVA: 0x00113BFC File Offset: 0x00111DFC
			// (set) Token: 0x0600381C RID: 14364 RVA: 0x00013662 File Offset: 0x00011862
			public unsafe UpdateLoopType HmLJOEaFHWwVymwfHWYgZGnwyFG
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateLoopDataSet<T>.zVJapvtWtEllziTivnvetEmjFKP.NativeFieldInfoPtr_HmLJOEaFHWwVymwfHWYgZGnwyFG);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateLoopDataSet<T>.zVJapvtWtEllziTivnvetEmjFKP.NativeFieldInfoPtr_HmLJOEaFHWwVymwfHWYgZGnwyFG)) = value;
				}
			}

			// Token: 0x170010B9 RID: 4281
			// (get) Token: 0x0600381D RID: 14365 RVA: 0x00113C24 File Offset: 0x00111E24
			// (set) Token: 0x0600381E RID: 14366 RVA: 0x00113C4C File Offset: 0x00111E4C
			public unsafe T lNPPGsBAWvbWdCjtDTNnwnbOjQw
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateLoopDataSet<T>.zVJapvtWtEllziTivnvetEmjFKP.NativeFieldInfoPtr_lNPPGsBAWvbWdCjtDTNnwnbOjQw);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateLoopDataSet<T>.zVJapvtWtEllziTivnvetEmjFKP.NativeFieldInfoPtr_lNPPGsBAWvbWdCjtDTNnwnbOjQw);
					Type typeFromHandle = typeof(T);
					if (!typeFromHandle.IsValueType)
					{
						if (!string.Equals(typeFromHandle.FullName, "System.String"))
						{
							IntPtr intPtr4;
							IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
							if (intPtr3 != 0)
							{
								intPtr4 = intPtr3;
								if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
								{
									IntPtr intPtr5 = intPtr3;
									cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
									return;
								}
							}
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
						}
						else
						{
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
						}
					}
					else
					{
						*intPtr2 = value;
					}
				}
			}

			// Token: 0x04002F50 RID: 12112
			private static readonly IntPtr NativeFieldInfoPtr_HmLJOEaFHWwVymwfHWYgZGnwyFG;

			// Token: 0x04002F51 RID: 12113
			private static readonly IntPtr NativeFieldInfoPtr_lNPPGsBAWvbWdCjtDTNnwnbOjQw;

			// Token: 0x04002F52 RID: 12114
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UpdateLoopType_0;
		}
	}
}
