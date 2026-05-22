using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Timeline
{
	// Token: 0x0200001A RID: 26
	[StructLayout(2)]
	public struct DiscreteTime
	{
		// Token: 0x060002FC RID: 764 RVA: 0x0001018C File Offset: 0x0000E38C
		// Note: this type is marked as 'beforefieldinit'.
		static DiscreteTime()
		{
			Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Timeline.dll", "UnityEngine.Timeline", "DiscreteTime");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr);
			DiscreteTime.NativeFieldInfoPtr_k_Tick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, "k_Tick");
			DiscreteTime.NativeFieldInfoPtr_kMaxTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, "kMaxTime");
			DiscreteTime.NativeFieldInfoPtr_m_DiscreteTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, "m_DiscreteTime");
			DiscreteTime.NativeMethodInfoPtr_get_tickValue_Public_Static_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663814);
			DiscreteTime.NativeMethodInfoPtr__ctor_Public_Void_DiscreteTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663815);
			DiscreteTime.NativeMethodInfoPtr__ctor_Private_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663816);
			DiscreteTime.NativeMethodInfoPtr__ctor_Public_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663817);
			DiscreteTime.NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663818);
			DiscreteTime.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663819);
			DiscreteTime.NativeMethodInfoPtr__ctor_Public_Void_Int32_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663820);
			DiscreteTime.NativeMethodInfoPtr_OneTickBefore_Public_DiscreteTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663821);
			DiscreteTime.NativeMethodInfoPtr_OneTickAfter_Public_DiscreteTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663822);
			DiscreteTime.NativeMethodInfoPtr_GetTick_Public_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663823);
			DiscreteTime.NativeMethodInfoPtr_FromTicks_Public_Static_DiscreteTime_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663824);
			DiscreteTime.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663825);
			DiscreteTime.NativeMethodInfoPtr_Equals_Public_Boolean_DiscreteTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663826);
			DiscreteTime.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663827);
			DiscreteTime.NativeMethodInfoPtr_DoubleToDiscreteTime_Private_Static_Int64_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663828);
			DiscreteTime.NativeMethodInfoPtr_FloatToDiscreteTime_Private_Static_Int64_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663829);
			DiscreteTime.NativeMethodInfoPtr_IntToDiscreteTime_Private_Static_Int64_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663830);
			DiscreteTime.NativeMethodInfoPtr_ToDouble_Private_Static_Double_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663831);
			DiscreteTime.NativeMethodInfoPtr_ToFloat_Private_Static_Single_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663832);
			DiscreteTime.NativeMethodInfoPtr_op_Explicit_Public_Static_Double_DiscreteTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663833);
			DiscreteTime.NativeMethodInfoPtr_op_Explicit_Public_Static_Single_DiscreteTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663834);
			DiscreteTime.NativeMethodInfoPtr_op_Explicit_Public_Static_Int64_DiscreteTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663835);
			DiscreteTime.NativeMethodInfoPtr_op_Explicit_Public_Static_DiscreteTime_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663836);
			DiscreteTime.NativeMethodInfoPtr_op_Explicit_Public_Static_DiscreteTime_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663837);
			DiscreteTime.NativeMethodInfoPtr_op_Implicit_Public_Static_DiscreteTime_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663838);
			DiscreteTime.NativeMethodInfoPtr_op_Explicit_Public_Static_DiscreteTime_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663839);
			DiscreteTime.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_DiscreteTime_DiscreteTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663840);
			DiscreteTime.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_DiscreteTime_DiscreteTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663841);
			DiscreteTime.NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_DiscreteTime_DiscreteTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663842);
			DiscreteTime.NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_DiscreteTime_DiscreteTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663843);
			DiscreteTime.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_Boolean_DiscreteTime_DiscreteTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663844);
			DiscreteTime.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_Boolean_DiscreteTime_DiscreteTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663845);
			DiscreteTime.NativeMethodInfoPtr_op_Addition_Public_Static_DiscreteTime_DiscreteTime_DiscreteTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663846);
			DiscreteTime.NativeMethodInfoPtr_op_Subtraction_Public_Static_DiscreteTime_DiscreteTime_DiscreteTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663847);
			DiscreteTime.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663848);
			DiscreteTime.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663849);
			DiscreteTime.NativeMethodInfoPtr_Min_Public_Static_DiscreteTime_DiscreteTime_DiscreteTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663850);
			DiscreteTime.NativeMethodInfoPtr_Max_Public_Static_DiscreteTime_DiscreteTime_DiscreteTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663851);
			DiscreteTime.NativeMethodInfoPtr_SnapToNearestTick_Public_Static_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663852);
			DiscreteTime.NativeMethodInfoPtr_SnapToNearestTick_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663853);
			DiscreteTime.NativeMethodInfoPtr_GetNearestTick_Public_Static_Int64_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663854);
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x060002FD RID: 765 RVA: 0x0001052C File Offset: 0x0000E72C
		public unsafe static double tickValue
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiscreteTime.NativeMethodInfoPtr_get_tickValue_Public_Static_get_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002FE RID: 766 RVA: 0x0001055C File Offset: 0x0000E75C
		[CallerCount(0)]
		public unsafe DiscreteTime(DiscreteTime time)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiscreteTime.NativeMethodInfoPtr__ctor_Public_Void_DiscreteTime_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002FF RID: 767 RVA: 0x00010590 File Offset: 0x0000E790
		[CallerCount(0)]
		public unsafe DiscreteTime(long time)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiscreteTime.NativeMethodInfoPtr__ctor_Private_Void_Int64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000300 RID: 768 RVA: 0x000105C4 File Offset: 0x0000E7C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 477514, XrefRangeEnd = 477518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DiscreteTime(double time)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiscreteTime.NativeMethodInfoPtr__ctor_Public_Void_Double_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000301 RID: 769 RVA: 0x000105F8 File Offset: 0x0000E7F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 477518, XrefRangeEnd = 477522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DiscreteTime(float time)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiscreteTime.NativeMethodInfoPtr__ctor_Public_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000302 RID: 770 RVA: 0x0001062C File Offset: 0x0000E82C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 477530, RefRangeEnd = 477534, XrefRangeStart = 477522, XrefRangeEnd = 477530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DiscreteTime(int time)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiscreteTime.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000303 RID: 771 RVA: 0x00010660 File Offset: 0x0000E860
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 477534, XrefRangeEnd = 477538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DiscreteTime(int frame, double fps)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref frame;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fps;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiscreteTime.NativeMethodInfoPtr__ctor_Public_Void_Int32_Double_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000304 RID: 772 RVA: 0x000106A0 File Offset: 0x0000E8A0
		[CallerCount(0)]
		public unsafe DiscreteTime OneTickBefore()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiscreteTime.NativeMethodInfoPtr_OneTickBefore_Public_DiscreteTime_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000305 RID: 773 RVA: 0x000106D0 File Offset: 0x0000E8D0
		[CallerCount(0)]
		public unsafe DiscreteTime OneTickAfter()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiscreteTime.NativeMethodInfoPtr_OneTickAfter_Public_DiscreteTime_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000306 RID: 774 RVA: 0x00010700 File Offset: 0x0000E900
		[CallerCount(0)]
		public unsafe long GetTick()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiscreteTime.NativeMethodInfoPtr_GetTick_Public_Int64_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000307 RID: 775 RVA: 0x00010730 File Offset: 0x0000E930
		[CallerCount(397)]
		[CachedScanResults(RefRangeStart = 12922, RefRangeEnd = 13319, XrefRangeStart = 12922, XrefRangeEnd = 13319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DiscreteTime FromTicks(long ticks)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ticks;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiscreteTime.NativeMethodInfoPtr_FromTicks_Public_Static_DiscreteTime_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000308 RID: 776 RVA: 0x00010770 File Offset: 0x0000E970
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 477538, XrefRangeEnd = 477540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiscreteTime.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000309 RID: 777 RVA: 0x000107B4 File Offset: 0x0000E9B4
		[CallerCount(0)]
		public unsafe bool Equals(DiscreteTime other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiscreteTime.NativeMethodInfoPtr_Equals_Public_Boolean_DiscreteTime_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600030A RID: 778 RVA: 0x000107F4 File Offset: 0x0000E9F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 477540, XrefRangeEnd = 477542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiscreteTime.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600030B RID: 779 RVA: 0x00010838 File Offset: 0x0000EA38
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 477542, RefRangeEnd = 477556, XrefRangeStart = 477542, XrefRangeEnd = 477542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long DoubleToDiscreteTime(double time)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiscreteTime.NativeMethodInfoPtr_DoubleToDiscreteTime_Private_Static_Int64_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600030C RID: 780 RVA: 0x00010878 File Offset: 0x0000EA78
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 477556, RefRangeEnd = 477559, XrefRangeStart = 477556, XrefRangeEnd = 477556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long FloatToDiscreteTime(float time)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiscreteTime.NativeMethodInfoPtr_FloatToDiscreteTime_Private_Static_Int64_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600030D RID: 781 RVA: 0x000108B8 File Offset: 0x0000EAB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 477559, XrefRangeEnd = 477563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long IntToDiscreteTime(int time)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiscreteTime.NativeMethodInfoPtr_IntToDiscreteTime_Private_Static_Int64_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600030E RID: 782 RVA: 0x000108F8 File Offset: 0x0000EAF8
		[CallerCount(0)]
		public unsafe static double ToDouble(long time)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiscreteTime.NativeMethodInfoPtr_ToDouble_Private_Static_Double_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600030F RID: 783 RVA: 0x00010938 File Offset: 0x0000EB38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 477563, XrefRangeEnd = 477566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float ToFloat(long time)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiscreteTime.NativeMethodInfoPtr_ToFloat_Private_Static_Single_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000310 RID: 784 RVA: 0x00010978 File Offset: 0x0000EB78
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 477569, RefRangeEnd = 477573, XrefRangeStart = 477566, XrefRangeEnd = 477569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator double(DiscreteTime b)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref b;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiscreteTime.NativeMethodInfoPtr_op_Explicit_Public_Static_Double_DiscreteTime_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000311 RID: 785 RVA: 0x000109B8 File Offset: 0x0000EBB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 477573, XrefRangeEnd = 477580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator float(DiscreteTime b)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref b;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiscreteTime.NativeMethodInfoPtr_op_Explicit_Public_Static_Single_DiscreteTime_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000312 RID: 786 RVA: 0x000109F8 File Offset: 0x0000EBF8
		[CallerCount(397)]
		[CachedScanResults(RefRangeStart = 12922, RefRangeEnd = 13319, XrefRangeStart = 12922, XrefRangeEnd = 13319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator long(DiscreteTime b)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref b;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiscreteTime.NativeMethodInfoPtr_op_Explicit_Public_Static_Int64_DiscreteTime_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000313 RID: 787 RVA: 0x00010A38 File Offset: 0x0000EC38
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 477584, RefRangeEnd = 477588, XrefRangeStart = 477580, XrefRangeEnd = 477584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator DiscreteTime(double time)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiscreteTime.NativeMethodInfoPtr_op_Explicit_Public_Static_DiscreteTime_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000314 RID: 788 RVA: 0x00010A78 File Offset: 0x0000EC78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 477588, XrefRangeEnd = 477592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator DiscreteTime(float time)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiscreteTime.NativeMethodInfoPtr_op_Explicit_Public_Static_DiscreteTime_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000315 RID: 789 RVA: 0x00010AB8 File Offset: 0x0000ECB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 477592, XrefRangeEnd = 477593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator DiscreteTime(int time)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiscreteTime.NativeMethodInfoPtr_op_Implicit_Public_Static_DiscreteTime_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000316 RID: 790 RVA: 0x00010AF8 File Offset: 0x0000ECF8
		[CallerCount(397)]
		[CachedScanResults(RefRangeStart = 12922, RefRangeEnd = 13319, XrefRangeStart = 12922, XrefRangeEnd = 13319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator DiscreteTime(long time)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiscreteTime.NativeMethodInfoPtr_op_Explicit_Public_Static_DiscreteTime_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000317 RID: 791 RVA: 0x00010B38 File Offset: 0x0000ED38
		[CallerCount(0)]
		public unsafe static bool operator ==(DiscreteTime lhs, DiscreteTime rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiscreteTime.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_DiscreteTime_DiscreteTime_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000318 RID: 792 RVA: 0x00010B84 File Offset: 0x0000ED84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 477596, RefRangeEnd = 477597, XrefRangeStart = 477593, XrefRangeEnd = 477596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(DiscreteTime lhs, DiscreteTime rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiscreteTime.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_DiscreteTime_DiscreteTime_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000319 RID: 793 RVA: 0x00010BD0 File Offset: 0x0000EDD0
		[CallerCount(0)]
		public unsafe static bool operator >(DiscreteTime lhs, DiscreteTime rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiscreteTime.NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_DiscreteTime_DiscreteTime_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600031A RID: 794 RVA: 0x00010C1C File Offset: 0x0000EE1C
		[CallerCount(0)]
		public unsafe static bool operator <(DiscreteTime lhs, DiscreteTime rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiscreteTime.NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_DiscreteTime_DiscreteTime_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600031B RID: 795 RVA: 0x00010C68 File Offset: 0x0000EE68
		[CallerCount(0)]
		public unsafe static bool operator <=(DiscreteTime lhs, DiscreteTime rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiscreteTime.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_Boolean_DiscreteTime_DiscreteTime_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600031C RID: 796 RVA: 0x00010CB4 File Offset: 0x0000EEB4
		[CallerCount(0)]
		public unsafe static bool operator >=(DiscreteTime lhs, DiscreteTime rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiscreteTime.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_Boolean_DiscreteTime_DiscreteTime_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600031D RID: 797 RVA: 0x00010D00 File Offset: 0x0000EF00
		[CallerCount(0)]
		public unsafe static DiscreteTime operator +(DiscreteTime lhs, DiscreteTime rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiscreteTime.NativeMethodInfoPtr_op_Addition_Public_Static_DiscreteTime_DiscreteTime_DiscreteTime_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600031E RID: 798 RVA: 0x00010D4C File Offset: 0x0000EF4C
		[CallerCount(0)]
		public unsafe static DiscreteTime operator -(DiscreteTime lhs, DiscreteTime rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiscreteTime.NativeMethodInfoPtr_op_Subtraction_Public_Static_DiscreteTime_DiscreteTime_DiscreteTime_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600031F RID: 799 RVA: 0x00010D98 File Offset: 0x0000EF98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiscreteTime.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000320 RID: 800 RVA: 0x00010DC4 File Offset: 0x0000EFC4
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiscreteTime.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000321 RID: 801 RVA: 0x00010DF4 File Offset: 0x0000EFF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 477597, XrefRangeEnd = 477600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DiscreteTime Min(DiscreteTime lhs, DiscreteTime rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiscreteTime.NativeMethodInfoPtr_Min_Public_Static_DiscreteTime_DiscreteTime_DiscreteTime_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000322 RID: 802 RVA: 0x00010E40 File Offset: 0x0000F040
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 477603, RefRangeEnd = 477604, XrefRangeStart = 477600, XrefRangeEnd = 477603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DiscreteTime Max(DiscreteTime lhs, DiscreteTime rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiscreteTime.NativeMethodInfoPtr_Max_Public_Static_DiscreteTime_DiscreteTime_DiscreteTime_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000323 RID: 803 RVA: 0x00010E8C File Offset: 0x0000F08C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 477604, XrefRangeEnd = 477608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double SnapToNearestTick(double time)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiscreteTime.NativeMethodInfoPtr_SnapToNearestTick_Public_Static_Double_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000324 RID: 804 RVA: 0x00010ECC File Offset: 0x0000F0CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 477608, XrefRangeEnd = 477615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float SnapToNearestTick(float time)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiscreteTime.NativeMethodInfoPtr_SnapToNearestTick_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000325 RID: 805 RVA: 0x00010F0C File Offset: 0x0000F10C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 477615, XrefRangeEnd = 477621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long GetNearestTick(double time)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiscreteTime.NativeMethodInfoPtr_GetNearestTick_Public_Static_Int64_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000326 RID: 806 RVA: 0x00002FCA File Offset: 0x000011CA
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, ref this));
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x06000327 RID: 807 RVA: 0x00010F4C File Offset: 0x0000F14C
		// (set) Token: 0x06000328 RID: 808 RVA: 0x00002FDC File Offset: 0x000011DC
		public unsafe static double k_Tick
		{
			get
			{
				double num;
				IL2CPP.il2cpp_field_static_get_value(DiscreteTime.NativeFieldInfoPtr_k_Tick, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DiscreteTime.NativeFieldInfoPtr_k_Tick, (void*)(&value));
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x06000329 RID: 809 RVA: 0x00010F68 File Offset: 0x0000F168
		// (set) Token: 0x0600032A RID: 810 RVA: 0x00002FEA File Offset: 0x000011EA
		public unsafe static DiscreteTime kMaxTime
		{
			get
			{
				DiscreteTime discreteTime;
				IL2CPP.il2cpp_field_static_get_value(DiscreteTime.NativeFieldInfoPtr_kMaxTime, (void*)(&discreteTime));
				return discreteTime;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DiscreteTime.NativeFieldInfoPtr_kMaxTime, (void*)(&value));
			}
		}

		// Token: 0x04000261 RID: 609
		private static readonly IntPtr NativeFieldInfoPtr_k_Tick;

		// Token: 0x04000262 RID: 610
		private static readonly IntPtr NativeFieldInfoPtr_kMaxTime;

		// Token: 0x04000263 RID: 611
		private static readonly IntPtr NativeFieldInfoPtr_m_DiscreteTime;

		// Token: 0x04000264 RID: 612
		private static readonly IntPtr NativeMethodInfoPtr_get_tickValue_Public_Static_get_Double_0;

		// Token: 0x04000265 RID: 613
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DiscreteTime_0;

		// Token: 0x04000266 RID: 614
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Int64_0;

		// Token: 0x04000267 RID: 615
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Double_0;

		// Token: 0x04000268 RID: 616
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;

		// Token: 0x04000269 RID: 617
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x0400026A RID: 618
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Double_0;

		// Token: 0x0400026B RID: 619
		private static readonly IntPtr NativeMethodInfoPtr_OneTickBefore_Public_DiscreteTime_0;

		// Token: 0x0400026C RID: 620
		private static readonly IntPtr NativeMethodInfoPtr_OneTickAfter_Public_DiscreteTime_0;

		// Token: 0x0400026D RID: 621
		private static readonly IntPtr NativeMethodInfoPtr_GetTick_Public_Int64_0;

		// Token: 0x0400026E RID: 622
		private static readonly IntPtr NativeMethodInfoPtr_FromTicks_Public_Static_DiscreteTime_Int64_0;

		// Token: 0x0400026F RID: 623
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0;

		// Token: 0x04000270 RID: 624
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Boolean_DiscreteTime_0;

		// Token: 0x04000271 RID: 625
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000272 RID: 626
		private static readonly IntPtr NativeMethodInfoPtr_DoubleToDiscreteTime_Private_Static_Int64_Double_0;

		// Token: 0x04000273 RID: 627
		private static readonly IntPtr NativeMethodInfoPtr_FloatToDiscreteTime_Private_Static_Int64_Single_0;

		// Token: 0x04000274 RID: 628
		private static readonly IntPtr NativeMethodInfoPtr_IntToDiscreteTime_Private_Static_Int64_Int32_0;

		// Token: 0x04000275 RID: 629
		private static readonly IntPtr NativeMethodInfoPtr_ToDouble_Private_Static_Double_Int64_0;

		// Token: 0x04000276 RID: 630
		private static readonly IntPtr NativeMethodInfoPtr_ToFloat_Private_Static_Single_Int64_0;

		// Token: 0x04000277 RID: 631
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_Double_DiscreteTime_0;

		// Token: 0x04000278 RID: 632
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_Single_DiscreteTime_0;

		// Token: 0x04000279 RID: 633
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_Int64_DiscreteTime_0;

		// Token: 0x0400027A RID: 634
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_DiscreteTime_Double_0;

		// Token: 0x0400027B RID: 635
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_DiscreteTime_Single_0;

		// Token: 0x0400027C RID: 636
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_DiscreteTime_Int32_0;

		// Token: 0x0400027D RID: 637
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_DiscreteTime_Int64_0;

		// Token: 0x0400027E RID: 638
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_DiscreteTime_DiscreteTime_0;

		// Token: 0x0400027F RID: 639
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_DiscreteTime_DiscreteTime_0;

		// Token: 0x04000280 RID: 640
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_DiscreteTime_DiscreteTime_0;

		// Token: 0x04000281 RID: 641
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_DiscreteTime_DiscreteTime_0;

		// Token: 0x04000282 RID: 642
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_Boolean_DiscreteTime_DiscreteTime_0;

		// Token: 0x04000283 RID: 643
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_Boolean_DiscreteTime_DiscreteTime_0;

		// Token: 0x04000284 RID: 644
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_DiscreteTime_DiscreteTime_DiscreteTime_0;

		// Token: 0x04000285 RID: 645
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_DiscreteTime_DiscreteTime_DiscreteTime_0;

		// Token: 0x04000286 RID: 646
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000287 RID: 647
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000288 RID: 648
		private static readonly IntPtr NativeMethodInfoPtr_Min_Public_Static_DiscreteTime_DiscreteTime_DiscreteTime_0;

		// Token: 0x04000289 RID: 649
		private static readonly IntPtr NativeMethodInfoPtr_Max_Public_Static_DiscreteTime_DiscreteTime_DiscreteTime_0;

		// Token: 0x0400028A RID: 650
		private static readonly IntPtr NativeMethodInfoPtr_SnapToNearestTick_Public_Static_Double_Double_0;

		// Token: 0x0400028B RID: 651
		private static readonly IntPtr NativeMethodInfoPtr_SnapToNearestTick_Public_Static_Single_Single_0;

		// Token: 0x0400028C RID: 652
		private static readonly IntPtr NativeMethodInfoPtr_GetNearestTick_Public_Static_Int64_Double_0;

		// Token: 0x0400028D RID: 653
		[FieldOffset(0)]
		public readonly long m_DiscreteTime;
	}
}
