using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200004B RID: 75
	public static class SECTR_Graph : global::Il2CppSystem.Object
	{
		// Token: 0x06000B10 RID: 2832 RVA: 0x00054FC8 File Offset: 0x000531C8
		// Note: this type is marked as 'beforefieldinit'.
		static SECTR_Graph()
		{
			Il2CppClassPointerStore<SECTR_Graph>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SECTR_Graph");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SECTR_Graph>.NativeClassPtr);
			SECTR_Graph.NativeFieldInfoPtr_initialSectors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Graph>.NativeClassPtr, "initialSectors");
			SECTR_Graph.NativeFieldInfoPtr_goalSectors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Graph>.NativeClassPtr, "goalSectors");
			SECTR_Graph.NativeFieldInfoPtr_openSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Graph>.NativeClassPtr, "openSet");
			SECTR_Graph.NativeFieldInfoPtr_closedSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Graph>.NativeClassPtr, "closedSet");
			SECTR_Graph.NativeMethodInfoPtr_DepthWalk_Public_Static_Void_byref_List_1_Node_SECTR_Sector_PortalFlags_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Graph>.NativeClassPtr, 100664224);
			SECTR_Graph.NativeMethodInfoPtr_BreadthWalk_Public_Static_Void_byref_List_1_Node_SECTR_Sector_PortalFlags_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Graph>.NativeClassPtr, 100664225);
			SECTR_Graph.NativeMethodInfoPtr_FindShortestPath_Public_Static_Void_byref_List_1_Node_Vector3_Vector3_PortalFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Graph>.NativeClassPtr, 100664226);
			SECTR_Graph.NativeMethodInfoPtr_GetGraphAsDot_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Graph>.NativeClassPtr, 100664227);
		}

		// Token: 0x06000B11 RID: 2833 RVA: 0x00055098 File Offset: 0x00053298
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40738, XrefRangeEnd = 40821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DepthWalk(ref List<SECTR_Graph.Node> nodes, SECTR_Sector root, SECTR_Portal.PortalFlags stopFlags, int maxDepth)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(nodes);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(root);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stopFlags;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDepth;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SECTR_Graph.NativeMethodInfoPtr_DepthWalk_Public_Static_Void_byref_List_1_Node_SECTR_Sector_PortalFlags_Int32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			nodes = ((intPtr4 == 0) ? null : new List<SECTR_Graph.Node>(intPtr4));
		}

		// Token: 0x06000B12 RID: 2834 RVA: 0x00055114 File Offset: 0x00053314
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40821, XrefRangeEnd = 40905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BreadthWalk(ref List<SECTR_Graph.Node> nodes, SECTR_Sector root, SECTR_Portal.PortalFlags stopFlags, int maxDepth)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(nodes);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(root);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stopFlags;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDepth;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SECTR_Graph.NativeMethodInfoPtr_BreadthWalk_Public_Static_Void_byref_List_1_Node_SECTR_Sector_PortalFlags_Int32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			nodes = ((intPtr4 == 0) ? null : new List<SECTR_Graph.Node>(intPtr4));
		}

		// Token: 0x06000B13 RID: 2835 RVA: 0x00055190 File Offset: 0x00053390
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40980, RefRangeEnd = 40982, XrefRangeStart = 40905, XrefRangeEnd = 40980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FindShortestPath(ref List<SECTR_Graph.Node> path, Vector3 start, Vector3 goal, SECTR_Portal.PortalFlags stopFlags)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(path);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref goal;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stopFlags;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SECTR_Graph.NativeMethodInfoPtr_FindShortestPath_Public_Static_Void_byref_List_1_Node_Vector3_Vector3_PortalFlags_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			path = ((intPtr4 == 0) ? null : new List<SECTR_Graph.Node>(intPtr4));
		}

		// Token: 0x06000B14 RID: 2836 RVA: 0x00055208 File Offset: 0x00053408
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40982, XrefRangeEnd = 41102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetGraphAsDot(string graphName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(graphName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_Graph.NativeMethodInfoPtr_GetGraphAsDot_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000B15 RID: 2837 RVA: 0x00008E10 File Offset: 0x00007010
		public SECTR_Graph(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x06000B16 RID: 2838 RVA: 0x00055244 File Offset: 0x00053444
		// (set) Token: 0x06000B17 RID: 2839 RVA: 0x00008E19 File Offset: 0x00007019
		public unsafe static List<SECTR_Sector> initialSectors
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SECTR_Graph.NativeFieldInfoPtr_initialSectors, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SECTR_Sector>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SECTR_Graph.NativeFieldInfoPtr_initialSectors, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x06000B18 RID: 2840 RVA: 0x0005526C File Offset: 0x0005346C
		// (set) Token: 0x06000B19 RID: 2841 RVA: 0x00008E2B File Offset: 0x0000702B
		public unsafe static List<SECTR_Sector> goalSectors
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SECTR_Graph.NativeFieldInfoPtr_goalSectors, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SECTR_Sector>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SECTR_Graph.NativeFieldInfoPtr_goalSectors, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000401 RID: 1025
		// (get) Token: 0x06000B1A RID: 2842 RVA: 0x00055294 File Offset: 0x00053494
		// (set) Token: 0x06000B1B RID: 2843 RVA: 0x00008E3D File Offset: 0x0000703D
		public unsafe static SECTR_PriorityQueue<SECTR_Graph.Node> openSet
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SECTR_Graph.NativeFieldInfoPtr_openSet, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_PriorityQueue<SECTR_Graph.Node>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SECTR_Graph.NativeFieldInfoPtr_openSet, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000402 RID: 1026
		// (get) Token: 0x06000B1C RID: 2844 RVA: 0x000552BC File Offset: 0x000534BC
		// (set) Token: 0x06000B1D RID: 2845 RVA: 0x00008E4F File Offset: 0x0000704F
		public unsafe static Dictionary<SECTR_Portal, SECTR_Graph.Node> closedSet
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SECTR_Graph.NativeFieldInfoPtr_closedSet, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<SECTR_Portal, SECTR_Graph.Node>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SECTR_Graph.NativeFieldInfoPtr_closedSet, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040006BB RID: 1723
		private static readonly IntPtr NativeFieldInfoPtr_initialSectors;

		// Token: 0x040006BC RID: 1724
		private static readonly IntPtr NativeFieldInfoPtr_goalSectors;

		// Token: 0x040006BD RID: 1725
		private static readonly IntPtr NativeFieldInfoPtr_openSet;

		// Token: 0x040006BE RID: 1726
		private static readonly IntPtr NativeFieldInfoPtr_closedSet;

		// Token: 0x040006BF RID: 1727
		private static readonly IntPtr NativeMethodInfoPtr_DepthWalk_Public_Static_Void_byref_List_1_Node_SECTR_Sector_PortalFlags_Int32_0;

		// Token: 0x040006C0 RID: 1728
		private static readonly IntPtr NativeMethodInfoPtr_BreadthWalk_Public_Static_Void_byref_List_1_Node_SECTR_Sector_PortalFlags_Int32_0;

		// Token: 0x040006C1 RID: 1729
		private static readonly IntPtr NativeMethodInfoPtr_FindShortestPath_Public_Static_Void_byref_List_1_Node_Vector3_Vector3_PortalFlags_0;

		// Token: 0x040006C2 RID: 1730
		private static readonly IntPtr NativeMethodInfoPtr_GetGraphAsDot_Public_Static_String_String_0;

		// Token: 0x020002BE RID: 702
		public class Node : global::Il2CppSystem.Object
		{
			// Token: 0x06004BB9 RID: 19385 RVA: 0x00117B2C File Offset: 0x00115D2C
			// Note: this type is marked as 'beforefieldinit'.
			static Node()
			{
				Il2CppClassPointerStore<SECTR_Graph.Node>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SECTR_Graph>.NativeClassPtr, "Node");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SECTR_Graph.Node>.NativeClassPtr);
				SECTR_Graph.Node.NativeFieldInfoPtr_Portal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Graph.Node>.NativeClassPtr, "Portal");
				SECTR_Graph.Node.NativeFieldInfoPtr_Sector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Graph.Node>.NativeClassPtr, "Sector");
				SECTR_Graph.Node.NativeFieldInfoPtr_CostPlusEstimate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Graph.Node>.NativeClassPtr, "CostPlusEstimate");
				SECTR_Graph.Node.NativeFieldInfoPtr_Cost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Graph.Node>.NativeClassPtr, "Cost");
				SECTR_Graph.Node.NativeFieldInfoPtr_Depth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Graph.Node>.NativeClassPtr, "Depth");
				SECTR_Graph.Node.NativeFieldInfoPtr_ForwardTraversal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Graph.Node>.NativeClassPtr, "ForwardTraversal");
				SECTR_Graph.Node.NativeFieldInfoPtr_Parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Graph.Node>.NativeClassPtr, "Parent");
				SECTR_Graph.Node.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Node_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Graph.Node>.NativeClassPtr, 100664229);
				SECTR_Graph.Node.NativeMethodInfoPtr_ReconstructPath_Public_Static_Void_List_1_Node_Node_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Graph.Node>.NativeClassPtr, 100664230);
				SECTR_Graph.Node.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Graph.Node>.NativeClassPtr, 100664231);
			}

			// Token: 0x06004BBA RID: 19386 RVA: 0x00117C20 File Offset: 0x00115E20
			[CallerCount(0)]
			public unsafe virtual int CompareTo(SECTR_Graph.Node other)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_Graph.Node.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Node_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004BBB RID: 19387 RVA: 0x00117C70 File Offset: 0x00115E70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40734, XrefRangeEnd = 40738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void ReconstructPath(List<SECTR_Graph.Node> path, SECTR_Graph.Node currentNode)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(path);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(currentNode);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_Graph.Node.NativeMethodInfoPtr_ReconstructPath_Public_Static_Void_List_1_Node_Node_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004BBC RID: 19388 RVA: 0x00117CB8 File Offset: 0x00115EB8
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Node()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SECTR_Graph.Node>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_Graph.Node.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004BBD RID: 19389 RVA: 0x0002C85B File Offset: 0x0002AA5B
			public Node(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001B92 RID: 7058
			// (get) Token: 0x06004BBE RID: 19390 RVA: 0x00117CF4 File Offset: 0x00115EF4
			// (set) Token: 0x06004BBF RID: 19391 RVA: 0x0002C864 File Offset: 0x0002AA64
			public unsafe SECTR_Portal Portal
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Graph.Node.NativeFieldInfoPtr_Portal);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_Portal>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Graph.Node.NativeFieldInfoPtr_Portal), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B93 RID: 7059
			// (get) Token: 0x06004BC0 RID: 19392 RVA: 0x00117D24 File Offset: 0x00115F24
			// (set) Token: 0x06004BC1 RID: 19393 RVA: 0x0002C883 File Offset: 0x0002AA83
			public unsafe SECTR_Sector Sector
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Graph.Node.NativeFieldInfoPtr_Sector);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_Sector>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Graph.Node.NativeFieldInfoPtr_Sector), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B94 RID: 7060
			// (get) Token: 0x06004BC2 RID: 19394 RVA: 0x00117D54 File Offset: 0x00115F54
			// (set) Token: 0x06004BC3 RID: 19395 RVA: 0x0002C8A2 File Offset: 0x0002AAA2
			public unsafe float CostPlusEstimate
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Graph.Node.NativeFieldInfoPtr_CostPlusEstimate);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Graph.Node.NativeFieldInfoPtr_CostPlusEstimate)) = value;
				}
			}

			// Token: 0x17001B95 RID: 7061
			// (get) Token: 0x06004BC4 RID: 19396 RVA: 0x00117D7C File Offset: 0x00115F7C
			// (set) Token: 0x06004BC5 RID: 19397 RVA: 0x0002C8BD File Offset: 0x0002AABD
			public unsafe float Cost
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Graph.Node.NativeFieldInfoPtr_Cost);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Graph.Node.NativeFieldInfoPtr_Cost)) = value;
				}
			}

			// Token: 0x17001B96 RID: 7062
			// (get) Token: 0x06004BC6 RID: 19398 RVA: 0x00117DA4 File Offset: 0x00115FA4
			// (set) Token: 0x06004BC7 RID: 19399 RVA: 0x0002C8D8 File Offset: 0x0002AAD8
			public unsafe int Depth
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Graph.Node.NativeFieldInfoPtr_Depth);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Graph.Node.NativeFieldInfoPtr_Depth)) = value;
				}
			}

			// Token: 0x17001B97 RID: 7063
			// (get) Token: 0x06004BC8 RID: 19400 RVA: 0x00117DCC File Offset: 0x00115FCC
			// (set) Token: 0x06004BC9 RID: 19401 RVA: 0x0002C8F3 File Offset: 0x0002AAF3
			public unsafe bool ForwardTraversal
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Graph.Node.NativeFieldInfoPtr_ForwardTraversal);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Graph.Node.NativeFieldInfoPtr_ForwardTraversal)) = value;
				}
			}

			// Token: 0x17001B98 RID: 7064
			// (get) Token: 0x06004BCA RID: 19402 RVA: 0x00117DF4 File Offset: 0x00115FF4
			// (set) Token: 0x06004BCB RID: 19403 RVA: 0x0002C90E File Offset: 0x0002AB0E
			public unsafe SECTR_Graph.Node Parent
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Graph.Node.NativeFieldInfoPtr_Parent);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_Graph.Node>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Graph.Node.NativeFieldInfoPtr_Parent), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040031A2 RID: 12706
			private static readonly IntPtr NativeFieldInfoPtr_Portal;

			// Token: 0x040031A3 RID: 12707
			private static readonly IntPtr NativeFieldInfoPtr_Sector;

			// Token: 0x040031A4 RID: 12708
			private static readonly IntPtr NativeFieldInfoPtr_CostPlusEstimate;

			// Token: 0x040031A5 RID: 12709
			private static readonly IntPtr NativeFieldInfoPtr_Cost;

			// Token: 0x040031A6 RID: 12710
			private static readonly IntPtr NativeFieldInfoPtr_Depth;

			// Token: 0x040031A7 RID: 12711
			private static readonly IntPtr NativeFieldInfoPtr_ForwardTraversal;

			// Token: 0x040031A8 RID: 12712
			private static readonly IntPtr NativeFieldInfoPtr_Parent;

			// Token: 0x040031A9 RID: 12713
			private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Node_0;

			// Token: 0x040031AA RID: 12714
			private static readonly IntPtr NativeMethodInfoPtr_ReconstructPath_Public_Static_Void_List_1_Node_Node_0;

			// Token: 0x040031AB RID: 12715
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
