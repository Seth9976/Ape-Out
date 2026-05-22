using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Il2CppRewired.Utils.Classes.Data
{
	// Token: 0x020001BB RID: 443
	public sealed class ReadOnlyArrayStruct<T> : ValueType
	{
		// Token: 0x06002E41 RID: 11841 RVA: 0x000E660C File Offset: 0x000E480C
		// Note: this type is marked as 'beforefieldinit'.
		static ReadOnlyArrayStruct()
		{
			Il2CppClassPointerStore<ReadOnlyArrayStruct<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Utils.Classes.Data", "ReadOnlyArrayStruct`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReadOnlyArrayStruct<T>>.NativeClassPtr);
			ReadOnlyArrayStruct<T>.NativeFieldInfoPtr_nCMgdFmnQSLCfMwlBKEBTFjpIGF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadOnlyArrayStruct<T>>.NativeClassPtr, "nCMgdFmnQSLCfMwlBKEBTFjpIGF");
			ReadOnlyArrayStruct<T>.NativeMethodInfoPtr_get_Length_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyArrayStruct<T>>.NativeClassPtr, 100675238);
			ReadOnlyArrayStruct<T>.NativeMethodInfoPtr_get_Item_Public_get_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyArrayStruct<T>>.NativeClassPtr, 100675239);
			ReadOnlyArrayStruct<T>.NativeMethodInfoPtr__ctor_Public_Void_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyArrayStruct<T>>.NativeClassPtr, 100675240);
		}

		// Token: 0x17000EAC RID: 3756
		// (get) Token: 0x06002E42 RID: 11842 RVA: 0x000E66C8 File Offset: 0x000E48C8
		public unsafe int Length
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyArrayStruct<T>.NativeMethodInfoPtr_get_Length_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000EAD RID: 3757
		public unsafe T this[int index]
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyArrayStruct<T>.NativeMethodInfoPtr_get_Item_Public_get_T_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
				}
			}
		}

		// Token: 0x06002E44 RID: 11844 RVA: 0x000E6758 File Offset: 0x000E4958
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 99329, RefRangeEnd = 99331, XrefRangeStart = 99329, XrefRangeEnd = 99331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReadOnlyArrayStruct(Il2CppArrayBase<T> array)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReadOnlyArrayStruct<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyArrayStruct<T>.NativeMethodInfoPtr__ctor_Public_Void_Il2CppArrayBase_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002E45 RID: 11845 RVA: 0x0001107A File Offset: 0x0000F27A
		public ReadOnlyArrayStruct(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06002E46 RID: 11846 RVA: 0x00011083 File Offset: 0x0000F283
		public ReadOnlyArrayStruct()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReadOnlyArrayStruct<T>>.NativeClassPtr))
		{
		}

		// Token: 0x17000EAB RID: 3755
		// (get) Token: 0x06002E47 RID: 11847 RVA: 0x000E67A8 File Offset: 0x000E49A8
		// (set) Token: 0x06002E48 RID: 11848 RVA: 0x00011095 File Offset: 0x0000F295
		public unsafe Il2CppArrayBase<T> nCMgdFmnQSLCfMwlBKEBTFjpIGF
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadOnlyArrayStruct<T>.NativeFieldInfoPtr_nCMgdFmnQSLCfMwlBKEBTFjpIGF);
				return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadOnlyArrayStruct<T>.NativeFieldInfoPtr_nCMgdFmnQSLCfMwlBKEBTFjpIGF), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002731 RID: 10033
		private static readonly IntPtr NativeFieldInfoPtr_nCMgdFmnQSLCfMwlBKEBTFjpIGF;

		// Token: 0x04002732 RID: 10034
		private static readonly IntPtr NativeMethodInfoPtr_get_Length_Public_get_Int32_0;

		// Token: 0x04002733 RID: 10035
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_T_Int32_0;

		// Token: 0x04002734 RID: 10036
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppArrayBase_1_T_0;
	}
}
