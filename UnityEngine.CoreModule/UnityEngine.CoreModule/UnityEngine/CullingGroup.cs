using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200004B RID: 75
	public class CullingGroup : Object
	{
		// Token: 0x06000396 RID: 918 RVA: 0x0001E560 File Offset: 0x0001C760
		// Note: this type is marked as 'beforefieldinit'.
		static CullingGroup()
		{
			Il2CppClassPointerStore<CullingGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "CullingGroup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CullingGroup>.NativeClassPtr);
			CullingGroup.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingGroup>.NativeClassPtr, "m_Ptr");
			CullingGroup.NativeFieldInfoPtr_m_OnStateChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingGroup>.NativeClassPtr, "m_OnStateChanged");
			CullingGroup.NativeMethodInfoPtr_SendEvents_Private_Static_Void_CullingGroup_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingGroup>.NativeClassPtr, 100663587);
			CullingGroup.DisposeInternalDelegateField = IL2CPP.ResolveICall<CullingGroup.DisposeInternalDelegate>("UnityEngine.CullingGroup::DisposeInternal");
			CullingGroup.get_enabledDelegateField = IL2CPP.ResolveICall<CullingGroup.get_enabledDelegate>("UnityEngine.CullingGroup::get_enabled");
			CullingGroup.set_enabledDelegateField = IL2CPP.ResolveICall<CullingGroup.set_enabledDelegate>("UnityEngine.CullingGroup::set_enabled");
			CullingGroup.get_targetCameraDelegateField = IL2CPP.ResolveICall<CullingGroup.get_targetCameraDelegate>("UnityEngine.CullingGroup::get_targetCamera");
			CullingGroup.set_targetCameraDelegateField = IL2CPP.ResolveICall<CullingGroup.set_targetCameraDelegate>("UnityEngine.CullingGroup::set_targetCamera");
			CullingGroup.SetBoundingSphereCountDelegateField = IL2CPP.ResolveICall<CullingGroup.SetBoundingSphereCountDelegate>("UnityEngine.CullingGroup::SetBoundingSphereCount");
			CullingGroup.EraseSwapBackDelegateField = IL2CPP.ResolveICall<CullingGroup.EraseSwapBackDelegate>("UnityEngine.CullingGroup::EraseSwapBack");
			CullingGroup.QueryIndicesDelegateField = IL2CPP.ResolveICall<CullingGroup.QueryIndicesDelegate>("UnityEngine.CullingGroup::QueryIndices");
			CullingGroup.IsVisibleDelegateField = IL2CPP.ResolveICall<CullingGroup.IsVisibleDelegate>("UnityEngine.CullingGroup::IsVisible");
			CullingGroup.GetDistanceDelegateField = IL2CPP.ResolveICall<CullingGroup.GetDistanceDelegate>("UnityEngine.CullingGroup::GetDistance");
			CullingGroup.SetBoundingDistancesDelegateField = IL2CPP.ResolveICall<CullingGroup.SetBoundingDistancesDelegate>("UnityEngine.CullingGroup::SetBoundingDistances");
			CullingGroup.SetDistanceReferencePoint_InternalTransformDelegateField = IL2CPP.ResolveICall<CullingGroup.SetDistanceReferencePoint_InternalTransformDelegate>("UnityEngine.CullingGroup::SetDistanceReferencePoint_InternalTransform");
			CullingGroup.InitDelegateField = IL2CPP.ResolveICall<CullingGroup.InitDelegate>("UnityEngine.CullingGroup::Init");
			CullingGroup.FinalizerFailureDelegateField = IL2CPP.ResolveICall<CullingGroup.FinalizerFailureDelegate>("UnityEngine.CullingGroup::FinalizerFailure");
			CullingGroup.SetDistanceReferencePoint_InternalVector3_InjectedDelegateField = IL2CPP.ResolveICall<CullingGroup.SetDistanceReferencePoint_InternalVector3_InjectedDelegate>("UnityEngine.CullingGroup::SetDistanceReferencePoint_InternalVector3_Injected");
		}

		// Token: 0x06000397 RID: 919 RVA: 0x0001E6B0 File Offset: 0x0001C8B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486729, XrefRangeEnd = 486730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SendEvents(CullingGroup cullingGroup, IntPtr eventsPtr, int count)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cullingGroup);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eventsPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CullingGroup.NativeMethodInfoPtr_SendEvents_Private_Static_Void_CullingGroup_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000398 RID: 920 RVA: 0x00003E77 File Offset: 0x00002077
		public CullingGroup(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x06000399 RID: 921 RVA: 0x0001E704 File Offset: 0x0001C904
		// (set) Token: 0x0600039A RID: 922 RVA: 0x00003E80 File Offset: 0x00002080
		public unsafe IntPtr m_Ptr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CullingGroup.NativeFieldInfoPtr_m_Ptr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CullingGroup.NativeFieldInfoPtr_m_Ptr)) = value;
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x0600039B RID: 923 RVA: 0x0001E72C File Offset: 0x0001C92C
		// (set) Token: 0x0600039C RID: 924 RVA: 0x00003E9B File Offset: 0x0000209B
		public unsafe CullingGroup.StateChanged m_OnStateChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CullingGroup.NativeFieldInfoPtr_m_OnStateChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CullingGroup.StateChanged>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CullingGroup.NativeFieldInfoPtr_m_OnStateChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0600039D RID: 925 RVA: 0x0001E75C File Offset: 0x0001C95C
		public override void Finalize()
		{
			try
			{
				bool flag = this.m_Ptr != IntPtr.Zero;
				if (flag)
				{
					this.FinalizerFailure();
				}
			}
			finally
			{
				base.Finalize();
			}
		}

		// Token: 0x0600039E RID: 926 RVA: 0x00003EBA File Offset: 0x000020BA
		public void DisposeInternal()
		{
			CullingGroup.DisposeInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x0600039F RID: 927 RVA: 0x00003ECC File Offset: 0x000020CC
		public void Dispose()
		{
			this.DisposeInternal();
			this.m_Ptr = IntPtr.Zero;
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x060003A0 RID: 928 RVA: 0x0001E7A4 File Offset: 0x0001C9A4
		// (set) Token: 0x060003A1 RID: 929 RVA: 0x00003EE1 File Offset: 0x000020E1
		public CullingGroup.StateChanged onStateChanged
		{
			get
			{
				return this.m_OnStateChanged;
			}
			set
			{
				this.m_OnStateChanged = value;
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x060003A2 RID: 930 RVA: 0x00003EEB File Offset: 0x000020EB
		// (set) Token: 0x060003A3 RID: 931 RVA: 0x00003EFD File Offset: 0x000020FD
		public bool enabled
		{
			get
			{
				return CullingGroup.get_enabledDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				CullingGroup.set_enabledDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x060003A4 RID: 932 RVA: 0x0001E7BC File Offset: 0x0001C9BC
		// (set) Token: 0x060003A5 RID: 933 RVA: 0x00003F10 File Offset: 0x00002110
		public Camera targetCamera
		{
			get
			{
				IntPtr intPtr = CullingGroup.get_targetCameraDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				CullingGroup.set_targetCameraDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x00003F28 File Offset: 0x00002128
		public void SetBoundingSphereCount(int count)
		{
			CullingGroup.SetBoundingSphereCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), count);
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x00003F3B File Offset: 0x0000213B
		public void EraseSwapBack(int index)
		{
			CullingGroup.EraseSwapBackDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index);
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x00003F4E File Offset: 0x0000214E
		public static void EraseSwapBack<T>(int index, Il2CppArrayBase<T> myArray, ref int size)
		{
			size--;
			myArray[index] = myArray[size];
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x0001E7E8 File Offset: 0x0001C9E8
		public int QueryIndices(bool visible, Il2CppStructArray<int> result, int firstIndex)
		{
			return this.QueryIndices(visible, -1, CullingQueryOptions.IgnoreDistance, result, firstIndex);
		}

		// Token: 0x060003AA RID: 938 RVA: 0x0001E808 File Offset: 0x0001CA08
		public int QueryIndices(int distanceIndex, Il2CppStructArray<int> result, int firstIndex)
		{
			return this.QueryIndices(false, distanceIndex, CullingQueryOptions.IgnoreVisibility, result, firstIndex);
		}

		// Token: 0x060003AB RID: 939 RVA: 0x0001E828 File Offset: 0x0001CA28
		public int QueryIndices(bool visible, int distanceIndex, Il2CppStructArray<int> result, int firstIndex)
		{
			return this.QueryIndices(visible, distanceIndex, CullingQueryOptions.Normal, result, firstIndex);
		}

		// Token: 0x060003AC RID: 940 RVA: 0x00003F66 File Offset: 0x00002166
		public int QueryIndices(bool visible, int distanceIndex, CullingQueryOptions options, Il2CppStructArray<int> result, int firstIndex)
		{
			return CullingGroup.QueryIndicesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), visible, distanceIndex, options, IL2CPP.Il2CppObjectBaseToPtr(result), firstIndex);
		}

		// Token: 0x060003AD RID: 941 RVA: 0x00003F84 File Offset: 0x00002184
		public bool IsVisible(int index)
		{
			return CullingGroup.IsVisibleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index);
		}

		// Token: 0x060003AE RID: 942 RVA: 0x00003F97 File Offset: 0x00002197
		public int GetDistance(int index)
		{
			return CullingGroup.GetDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index);
		}

		// Token: 0x060003AF RID: 943 RVA: 0x00003FAA File Offset: 0x000021AA
		public void SetBoundingDistances(Il2CppStructArray<float> distances)
		{
			CullingGroup.SetBoundingDistancesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(distances));
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x00003FC2 File Offset: 0x000021C2
		public void SetDistanceReferencePoint_InternalVector3(Vector3 point)
		{
			this.SetDistanceReferencePoint_InternalVector3_Injected(ref point);
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x00003FCC File Offset: 0x000021CC
		public void SetDistanceReferencePoint_InternalTransform(Transform transform)
		{
			CullingGroup.SetDistanceReferencePoint_InternalTransformDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(transform));
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x00003FE4 File Offset: 0x000021E4
		public void SetDistanceReferencePoint(Vector3 point)
		{
			this.SetDistanceReferencePoint_InternalVector3(point);
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x00003FEF File Offset: 0x000021EF
		public void SetDistanceReferencePoint(Transform transform)
		{
			this.SetDistanceReferencePoint_InternalTransform(transform);
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x00003FFA File Offset: 0x000021FA
		public static IntPtr Init(Object scripting)
		{
			return CullingGroup.InitDelegateField(IL2CPP.Il2CppObjectBaseToPtr(scripting));
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x0000400C File Offset: 0x0000220C
		public void FinalizerFailure()
		{
			CullingGroup.FinalizerFailureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x0000401E File Offset: 0x0000221E
		public void SetDistanceReferencePoint_InternalVector3_Injected(ref Vector3 point)
		{
			CullingGroup.SetDistanceReferencePoint_InternalVector3_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref point);
		}

		// Token: 0x040002E2 RID: 738
		private static readonly IntPtr NativeFieldInfoPtr_m_Ptr;

		// Token: 0x040002E3 RID: 739
		private static readonly IntPtr NativeFieldInfoPtr_m_OnStateChanged;

		// Token: 0x040002E4 RID: 740
		private static readonly IntPtr NativeMethodInfoPtr_SendEvents_Private_Static_Void_CullingGroup_IntPtr_Int32_0;

		// Token: 0x040002E5 RID: 741
		private static readonly CullingGroup.DisposeInternalDelegate DisposeInternalDelegateField;

		// Token: 0x040002E6 RID: 742
		private static readonly CullingGroup.get_enabledDelegate get_enabledDelegateField;

		// Token: 0x040002E7 RID: 743
		private static readonly CullingGroup.set_enabledDelegate set_enabledDelegateField;

		// Token: 0x040002E8 RID: 744
		private static readonly CullingGroup.get_targetCameraDelegate get_targetCameraDelegateField;

		// Token: 0x040002E9 RID: 745
		private static readonly CullingGroup.set_targetCameraDelegate set_targetCameraDelegateField;

		// Token: 0x040002EA RID: 746
		private static readonly CullingGroup.SetBoundingSphereCountDelegate SetBoundingSphereCountDelegateField;

		// Token: 0x040002EB RID: 747
		private static readonly CullingGroup.EraseSwapBackDelegate EraseSwapBackDelegateField;

		// Token: 0x040002EC RID: 748
		private static readonly CullingGroup.QueryIndicesDelegate QueryIndicesDelegateField;

		// Token: 0x040002ED RID: 749
		private static readonly CullingGroup.IsVisibleDelegate IsVisibleDelegateField;

		// Token: 0x040002EE RID: 750
		private static readonly CullingGroup.GetDistanceDelegate GetDistanceDelegateField;

		// Token: 0x040002EF RID: 751
		private static readonly CullingGroup.SetBoundingDistancesDelegate SetBoundingDistancesDelegateField;

		// Token: 0x040002F0 RID: 752
		private static readonly CullingGroup.SetDistanceReferencePoint_InternalTransformDelegate SetDistanceReferencePoint_InternalTransformDelegateField;

		// Token: 0x040002F1 RID: 753
		private static readonly CullingGroup.InitDelegate InitDelegateField;

		// Token: 0x040002F2 RID: 754
		private static readonly CullingGroup.FinalizerFailureDelegate FinalizerFailureDelegateField;

		// Token: 0x040002F3 RID: 755
		private static readonly CullingGroup.SetDistanceReferencePoint_InternalVector3_InjectedDelegate SetDistanceReferencePoint_InternalVector3_InjectedDelegateField;

		// Token: 0x020003CE RID: 974
		public sealed class StateChanged : MulticastDelegate
		{
			// Token: 0x060025C2 RID: 9666 RVA: 0x0007AEC8 File Offset: 0x000790C8
			// Note: this type is marked as 'beforefieldinit'.
			static StateChanged()
			{
				Il2CppClassPointerStore<CullingGroup.StateChanged>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CullingGroup>.NativeClassPtr, "StateChanged");
				CullingGroup.StateChanged.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingGroup.StateChanged>.NativeClassPtr, 100663588);
				CullingGroup.StateChanged.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_CullingGroupEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingGroup.StateChanged>.NativeClassPtr, 100663589);
				CullingGroup.StateChanged.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_CullingGroupEvent_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingGroup.StateChanged>.NativeClassPtr, 100663590);
				CullingGroup.StateChanged.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingGroup.StateChanged>.NativeClassPtr, 100663591);
			}

			// Token: 0x060025C3 RID: 9667 RVA: 0x0007AF3C File Offset: 0x0007913C
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe StateChanged(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CullingGroup.StateChanged>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CullingGroup.StateChanged.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060025C4 RID: 9668 RVA: 0x0007AF98 File Offset: 0x00079198
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 486724, RefRangeEnd = 486725, XrefRangeStart = 486724, XrefRangeEnd = 486724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(CullingGroupEvent sphere)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref sphere;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CullingGroup.StateChanged.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_CullingGroupEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060025C5 RID: 9669 RVA: 0x0007AFD8 File Offset: 0x000791D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486725, XrefRangeEnd = 486729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(CullingGroupEvent sphere, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref sphere;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CullingGroup.StateChanged.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_CullingGroupEvent_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x060025C6 RID: 9670 RVA: 0x0007B048 File Offset: 0x00079248
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CullingGroup.StateChanged.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060025C7 RID: 9671 RVA: 0x00013670 File Offset: 0x00011870
			public StateChanged(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060025C8 RID: 9672 RVA: 0x00013679 File Offset: 0x00011879
			public static implicit operator CullingGroup.StateChanged(Action<CullingGroupEvent> A_0)
			{
				return DelegateSupport.ConvertDelegate<CullingGroup.StateChanged>(A_0);
			}

			// Token: 0x060025C9 RID: 9673 RVA: 0x00013681 File Offset: 0x00011881
			public static CullingGroup.StateChanged operator +(CullingGroup.StateChanged A_0, CullingGroup.StateChanged A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<CullingGroup.StateChanged>();
			}

			// Token: 0x060025CA RID: 9674 RVA: 0x0001368F File Offset: 0x0001188F
			public static CullingGroup.StateChanged operator -(CullingGroup.StateChanged A_0, CullingGroup.StateChanged A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<CullingGroup.StateChanged>();
				}
				return delegate2;
			}

			// Token: 0x04001EC4 RID: 7876
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001EC5 RID: 7877
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_CullingGroupEvent_0;

			// Token: 0x04001EC6 RID: 7878
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_CullingGroupEvent_AsyncCallback_Object_0;

			// Token: 0x04001EC7 RID: 7879
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x020003CF RID: 975
		// (Invoke) Token: 0x060025CC RID: 9676
		private delegate void DisposeInternalDelegate(IntPtr @this);

		// Token: 0x020003D0 RID: 976
		// (Invoke) Token: 0x060025CE RID: 9678
		private delegate bool get_enabledDelegate(IntPtr @this);

		// Token: 0x020003D1 RID: 977
		// (Invoke) Token: 0x060025D0 RID: 9680
		private delegate void set_enabledDelegate(IntPtr @this, bool value);

		// Token: 0x020003D2 RID: 978
		// (Invoke) Token: 0x060025D2 RID: 9682
		private delegate IntPtr get_targetCameraDelegate(IntPtr @this);

		// Token: 0x020003D3 RID: 979
		// (Invoke) Token: 0x060025D4 RID: 9684
		private delegate void set_targetCameraDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020003D4 RID: 980
		// (Invoke) Token: 0x060025D6 RID: 9686
		private delegate void SetBoundingSphereCountDelegate(IntPtr @this, int count);

		// Token: 0x020003D5 RID: 981
		// (Invoke) Token: 0x060025D8 RID: 9688
		private delegate void EraseSwapBackDelegate(IntPtr @this, int index);

		// Token: 0x020003D6 RID: 982
		// (Invoke) Token: 0x060025DA RID: 9690
		private delegate int QueryIndicesDelegate(IntPtr @this, bool visible, int distanceIndex, CullingQueryOptions options, IntPtr result, int firstIndex);

		// Token: 0x020003D7 RID: 983
		// (Invoke) Token: 0x060025DC RID: 9692
		private delegate bool IsVisibleDelegate(IntPtr @this, int index);

		// Token: 0x020003D8 RID: 984
		// (Invoke) Token: 0x060025DE RID: 9694
		private delegate int GetDistanceDelegate(IntPtr @this, int index);

		// Token: 0x020003D9 RID: 985
		// (Invoke) Token: 0x060025E0 RID: 9696
		private delegate void SetBoundingDistancesDelegate(IntPtr @this, IntPtr distances);

		// Token: 0x020003DA RID: 986
		// (Invoke) Token: 0x060025E2 RID: 9698
		private delegate void SetDistanceReferencePoint_InternalTransformDelegate(IntPtr @this, IntPtr transform);

		// Token: 0x020003DB RID: 987
		// (Invoke) Token: 0x060025E4 RID: 9700
		private delegate IntPtr InitDelegate(IntPtr scripting);

		// Token: 0x020003DC RID: 988
		// (Invoke) Token: 0x060025E6 RID: 9702
		private delegate void FinalizerFailureDelegate(IntPtr @this);

		// Token: 0x020003DD RID: 989
		// (Invoke) Token: 0x060025E8 RID: 9704
		private delegate void SetDistanceReferencePoint_InternalVector3_InjectedDelegate(IntPtr @this, IntPtr point);
	}
}
