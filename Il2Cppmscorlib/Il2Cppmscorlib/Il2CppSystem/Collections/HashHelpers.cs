using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Collections
{
	// Token: 0x02000477 RID: 1143
	public static class HashHelpers : Object
	{
		// Token: 0x060045B8 RID: 17848 RVA: 0x00140A58 File Offset: 0x0013EC58
		// Note: this type is marked as 'beforefieldinit'.
		static HashHelpers()
		{
			Il2CppClassPointerStore<HashHelpers>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections", "HashHelpers");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HashHelpers>.NativeClassPtr);
			HashHelpers.NativeFieldInfoPtr_primes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HashHelpers>.NativeClassPtr, "primes");
			HashHelpers.NativeFieldInfoPtr_s_SerializationInfoTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HashHelpers>.NativeClassPtr, "s_SerializationInfoTable");
			HashHelpers.NativeMethodInfoPtr_get_SerializationInfoTable_Internal_Static_get_ConditionalWeakTable_2_Object_SerializationInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashHelpers>.NativeClassPtr, 100673522);
			HashHelpers.NativeMethodInfoPtr_IsPrime_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashHelpers>.NativeClassPtr, 100673523);
			HashHelpers.NativeMethodInfoPtr_GetPrime_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashHelpers>.NativeClassPtr, 100673524);
			HashHelpers.NativeMethodInfoPtr_ExpandPrime_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashHelpers>.NativeClassPtr, 100673525);
		}

		// Token: 0x170011C6 RID: 4550
		// (get) Token: 0x060045B9 RID: 17849 RVA: 0x00140B00 File Offset: 0x0013ED00
		public unsafe static ConditionalWeakTable<Object, SerializationInfo> SerializationInfoTable
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 229484, RefRangeEnd = 229488, XrefRangeStart = 229468, XrefRangeEnd = 229484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashHelpers.NativeMethodInfoPtr_get_SerializationInfoTable_Internal_Static_get_ConditionalWeakTable_2_Object_SerializationInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConditionalWeakTable<Object, SerializationInfo>>(intPtr3) : null;
			}
		}

		// Token: 0x060045BA RID: 17850 RVA: 0x00140B34 File Offset: 0x0013ED34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 229489, RefRangeEnd = 229490, XrefRangeStart = 229488, XrefRangeEnd = 229489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsPrime(int candidate)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref candidate;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashHelpers.NativeMethodInfoPtr_IsPrime_Public_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060045BB RID: 17851 RVA: 0x00140B74 File Offset: 0x0013ED74
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 229501, RefRangeEnd = 229505, XrefRangeStart = 229490, XrefRangeEnd = 229501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetPrime(int min)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref min;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashHelpers.NativeMethodInfoPtr_GetPrime_Public_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060045BC RID: 17852 RVA: 0x00140BB4 File Offset: 0x0013EDB4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 229506, RefRangeEnd = 229510, XrefRangeStart = 229505, XrefRangeEnd = 229506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ExpandPrime(int oldSize)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref oldSize;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashHelpers.NativeMethodInfoPtr_ExpandPrime_Public_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060045BD RID: 17853 RVA: 0x0001A81B File Offset: 0x00018A1B
		public HashHelpers(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170011C4 RID: 4548
		// (get) Token: 0x060045BE RID: 17854 RVA: 0x00140BF4 File Offset: 0x0013EDF4
		// (set) Token: 0x060045BF RID: 17855 RVA: 0x0001A824 File Offset: 0x00018A24
		public unsafe static Il2CppStructArray<int> primes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HashHelpers.NativeFieldInfoPtr_primes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HashHelpers.NativeFieldInfoPtr_primes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011C5 RID: 4549
		// (get) Token: 0x060045C0 RID: 17856 RVA: 0x00140C1C File Offset: 0x0013EE1C
		// (set) Token: 0x060045C1 RID: 17857 RVA: 0x0001A836 File Offset: 0x00018A36
		public unsafe static ConditionalWeakTable<Object, SerializationInfo> s_SerializationInfoTable
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HashHelpers.NativeFieldInfoPtr_s_SerializationInfoTable, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConditionalWeakTable<Object, SerializationInfo>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HashHelpers.NativeFieldInfoPtr_s_SerializationInfoTable, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040038B8 RID: 14520
		private static readonly IntPtr NativeFieldInfoPtr_primes;

		// Token: 0x040038B9 RID: 14521
		private static readonly IntPtr NativeFieldInfoPtr_s_SerializationInfoTable;

		// Token: 0x040038BA RID: 14522
		private static readonly IntPtr NativeMethodInfoPtr_get_SerializationInfoTable_Internal_Static_get_ConditionalWeakTable_2_Object_SerializationInfo_0;

		// Token: 0x040038BB RID: 14523
		private static readonly IntPtr NativeMethodInfoPtr_IsPrime_Public_Static_Boolean_Int32_0;

		// Token: 0x040038BC RID: 14524
		private static readonly IntPtr NativeMethodInfoPtr_GetPrime_Public_Static_Int32_Int32_0;

		// Token: 0x040038BD RID: 14525
		private static readonly IntPtr NativeMethodInfoPtr_ExpandPrime_Public_Static_Int32_Int32_0;
	}
}
