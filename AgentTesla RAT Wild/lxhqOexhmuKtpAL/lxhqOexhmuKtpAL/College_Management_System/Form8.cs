using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ADODB;
using College_Management_System.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace College_Management_System
{
	// Token: 0x02000018 RID: 24
	[DesignerGenerated]
	public class Form8 : Form
	{
		// Token: 0x060001E2 RID: 482 RVA: 0x0001B3AC File Offset: 0x000195AC
		public Form8()
		{
			for (;;)
			{
				IL_100:
				int num = 12;
				int num2 = 12;
				for (;;)
				{
					num2 ^= 84;
					for (;;)
					{
						IL_45:
						int num3 = Form12.wsyoqrrjsoniul(48);
						int num4 = Form7.mqgfoefwabbyeu(19);
						for (;;)
						{
							num4 ^= 87;
							switch (num4 + 92)
							{
							case 0:
								goto IL_45;
							case 1:
							{
								RuntimeMethodHandle runtimeMethodHandle = methodof(Form8.set_txtID(TextBox)).MethodHandle;
								num4 = -14;
								continue;
							}
							case 2:
								switch (num3 + 81)
								{
								case 0:
									break;
								case 1:
								{
									RuntimeMethodHandle runtimeMethodHandle2 = methodof(Form8.nxfpeikhibypgj(object, EventArgs)).MethodHandle;
									num3 = -31;
									goto IL_22;
								}
								case 2:
									switch (num2)
									{
									case 85:
										switch (num)
										{
										case 81:
											this.nxfpeikhibypgd();
											num = 15;
											goto IL_11;
										case 82:
										{
											RuntimeMethodHandle runtimeMethodHandle3 = methodof(Form8.get_txtPhone()).MethodHandle;
											num = 10;
											goto IL_11;
										}
										case 83:
											this.con = (Connection)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("00000514-0000-0010-8000-00AA006D2EA4")));
											num = 14;
											goto IL_11;
										case 84:
											base.Load += this.nxfpeikhibypge;
											num = 13;
											goto IL_11;
										case 85:
											num = 11;
											goto IL_11;
										case 86:
											this.rs = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("00000535-0000-0010-8000-00AA006D2EA4")));
											num = 9;
											goto IL_11;
										case 87:
											num = 0;
											goto IL_11;
										case 88:
											return;
										}
										goto Block_3;
									case 86:
										goto IL_F3;
									case 87:
										goto IL_100;
									case 88:
										break;
									default:
										num3 = -2;
										goto IL_22;
									}
									IL_11:
									num ^= 88;
									break;
								case 3:
									goto IL_BE;
								default:
									num4 = -13;
									continue;
								}
								num2 = 1;
								num3 = Form12.wsyoqrrjsoniul(52);
								goto IL_22;
							case 3:
								goto IL_22;
							}
							IL_3B:
							num4 = Form7.mqgfoefwabbyeu(23);
							continue;
							IL_22:
							num3 ^= 81;
							goto IL_3B;
						}
					}
					IL_BE:
					continue;
					Block_3:
					num2 = 3;
					continue;
					IL_F3:
					RuntimeMethodHandle runtimeMethodHandle4 = methodof(Form8.get_rbFemale()).MethodHandle;
					num2 = 2;
				}
			}
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x0001B598 File Offset: 0x00019798
		[DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				bool flag = disposing && this.components != null;
				if (flag)
				{
					for (;;)
					{
						IL_F0:
						int num = Form12.wsyoqrrjsoniul(43);
						int num2 = 8;
						for (;;)
						{
							num2 ^= 92;
							for (;;)
							{
								IL_A9:
								int num3 = 28;
								int num4 = 11;
								for (;;)
								{
									switch (num4 ^ 82)
									{
									case 86:
									{
										RuntimeMethodHandle runtimeMethodHandle = methodof(Form8.set_txtPhone(TextBox)).MethodHandle;
										num4 = 4;
										continue;
									}
									case 87:
										switch (num3)
										{
										case 79:
											switch (num2)
											{
											case 81:
												goto IL_F0;
											case 82:
												goto IL_FF;
											case 83:
												switch (num + 79)
												{
												case 0:
													this.components.Dispose();
													num = Form2.uwpnsrqhswlmjh(45);
													goto IL_3E;
												case 1:
													num = -17;
													goto IL_3E;
												case 2:
												{
													RuntimeMethodHandle runtimeMethodHandle2 = methodof(Form8.get_Label5()).MethodHandle;
													num = -24;
													goto IL_3E;
												}
												case 3:
													goto IL_18B;
												}
												goto Block_6;
											case 84:
												break;
											default:
												num3 = 2;
												goto IL_4F;
											}
											IL_3E:
											num ^= 91;
											break;
										case 80:
										{
											RuntimeMethodHandle runtimeMethodHandle3 = methodof(Form8.get_rbFemale()).MethodHandle;
											num3 = 3;
											goto IL_4F;
										}
										case 81:
											break;
										case 82:
											goto IL_EB;
										default:
											num4 = 10;
											continue;
										}
										num2 = 15;
										num3 = 1;
										break;
									case 88:
										goto IL_A9;
									case 89:
										break;
									default:
										IL_7A:
										num4 = 5;
										continue;
									}
									IL_4F:
									num3 ^= 83;
									goto IL_7A;
								}
							}
							IL_EB:
							continue;
							IL_FF:
							RuntimeMethodHandle runtimeMethodHandle4 = methodof(Form8.get_txtEmail()).MethodHandle;
							num2 = 14;
							continue;
							Block_6:
							num2 = 13;
						}
					}
					IL_18B:;
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x0001B75C File Offset: 0x0001995C
		[DebuggerStepThrough]
		private void nxfpeikhibypgd()
		{
			for (;;)
			{
				int num = Form2.uwpnsrqhswlmjh(50);
				for (;;)
				{
					num ^= 86;
					switch (num + 90)
					{
					case 0:
						base.Controls.Add(this.cboTitle);
						for (;;)
						{
							int num2 = Form7.mqgfoefwabbyeu(29);
							for (;;)
							{
								num2 ^= 89;
								switch (num2 + 83)
								{
								case 0:
									base.Controls.Add(this.txtLastName);
									num2 = -18;
									continue;
								case 1:
									base.Controls.Add(this.txtID);
									num2 = -21;
									continue;
								case 2:
									base.Controls.Add(this.lblWelcome);
									num2 = -29;
									continue;
								case 3:
									base.Controls.Add(this.rbMale);
									num2 = -31;
									continue;
								case 4:
									base.Controls.Add(this.Label6);
									num2 = -19;
									continue;
								case 5:
									base.Controls.Add(this.Label8);
									num2 = -24;
									continue;
								case 6:
									base.Controls.Add(this.txtPhone);
									num2 = -12;
									continue;
								case 7:
									base.Controls.Add(this.Label5);
									num2 = -27;
									continue;
								case 8:
								{
									RuntimeMethodHandle runtimeMethodHandle = methodof(Form8.set_txtFirstName(TextBox)).MethodHandle;
									num2 = -20;
									continue;
								}
								case 9:
									base.Controls.Add(this.DateTimePicker1);
									num2 = -30;
									continue;
								case 10:
									base.Controls.Add(this.txtFirstName);
									num2 = -9;
									continue;
								case 11:
									base.Controls.Add(this.cmdPhoto);
									num2 = -32;
									continue;
								case 12:
									base.Controls.Add(this.PictureBox1);
									num2 = -17;
									continue;
								case 13:
									base.Controls.Add(this.rbFemale);
									num2 = -23;
									continue;
								case 14:
									base.Controls.Add(this.txtEmail);
									num2 = -22;
									continue;
								case 15:
									goto IL_1C1;
								}
								break;
							}
						}
						IL_1C1:
						num = -19;
						continue;
					case 1:
						this.cmdSave.BackColor = Color.BlueViolet;
						this.cmdSave.Location = new Point(116, 22);
						this.cmdSave.Name = "cmdSave";
						this.cmdSave.Size = new Size(98, 34);
						this.cmdSave.TabIndex = 63;
						this.cmdSave.Text = "SAVE";
						this.cmdSave.UseVisualStyleBackColor = false;
						this.cmdSearch.BackColor = Color.BlueViolet;
						this.cmdSearch.ForeColor = Color.White;
						this.cmdSearch.Location = new Point(326, 22);
						this.cmdSearch.Name = "cmdSearch";
						this.cmdSearch.Size = new Size(98, 34);
						this.cmdSearch.TabIndex = 119;
						this.cmdSearch.Text = "SEARCH";
						this.cmdSearch.UseVisualStyleBackColor = false;
						num = -1;
						continue;
					case 2:
						this.cmdNext.Name = "cmdNext";
						this.cmdNext.Size = new Size(101, 34);
						this.cmdNext.TabIndex = 116;
						this.cmdNext.Text = "NEXT";
						this.cmdNext.UseVisualStyleBackColor = false;
						this.cmdPrevious.BackColor = Color.BlueViolet;
						this.cmdPrevious.ForeColor = Color.White;
						this.cmdPrevious.Location = new Point(145, 65);
						this.cmdPrevious.Name = "cmdPrevious";
						this.cmdPrevious.Size = new Size(101, 34);
						this.cmdPrevious.TabIndex = 115;
						this.cmdPrevious.Text = "PREVIOUS";
						this.cmdPrevious.UseVisualStyleBackColor = false;
						this.cmdLast.BackColor = Color.BlueViolet;
						this.cmdLast.ForeColor = Color.White;
						num = -8;
						continue;
					case 3:
						this.GroupBox2.Controls.Add(this.cmdNext);
						this.GroupBox2.Controls.Add(this.cmdPrevious);
						this.GroupBox2.Controls.Add(this.cmdLast);
						this.GroupBox2.Controls.Add(this.cmdFirst);
						this.GroupBox2.ForeColor = Color.White;
						this.GroupBox2.Location = new Point(483, 434);
						this.GroupBox2.Name = "GroupBox2";
						this.GroupBox2.Size = new Size(273, 112);
						this.GroupBox2.TabIndex = 167;
						this.GroupBox2.TabStop = false;
						this.GroupBox2.Text = "Navigation";
						this.cmdNext.BackColor = Color.BlueViolet;
						this.cmdNext.ForeColor = Color.White;
						this.cmdNext.Location = new Point(28, 65);
						num = -2;
						continue;
					case 4:
						this.GroupBox1.Controls.Add(this.cmdEdit);
						for (;;)
						{
							int num3 = 7;
							for (;;)
							{
								switch (num3 ^ 81)
								{
								case 83:
									this.GroupBox1.Location = new Point(29, 434);
									num3 = 12;
									continue;
								case 84:
									this.GroupBox1.TabStop = false;
									num3 = 9;
									continue;
								case 85:
									this.GroupBox1.Controls.Add(this.cmdUpdate);
									num3 = 15;
									continue;
								case 86:
									this.GroupBox1.Controls.Add(this.cmdDisplay);
									num3 = 4;
									continue;
								case 87:
								{
									RuntimeMethodHandle runtimeMethodHandle2 = methodof(Form8.get_Label8()).MethodHandle;
									num3 = 6;
									continue;
								}
								case 88:
									this.GroupBox1.Text = "Commands";
									num3 = 10;
									continue;
								case 89:
									this.GroupBox1.Controls.Add(this.cmdAdd);
									num3 = 13;
									continue;
								case 90:
									this.GroupBox1.Controls.Add(this.cmdSave);
									num3 = 8;
									continue;
								case 91:
									this.cmdBack.BackColor = Color.BlueViolet;
									num3 = 51;
									continue;
								case 92:
									this.GroupBox1.Controls.Add(this.cmdSearch);
									num3 = 48;
									continue;
								case 93:
									this.GroupBox1.Name = "GroupBox1";
									num3 = 14;
									continue;
								case 94:
									this.GroupBox1.Controls.Add(this.cmdDelete);
									num3 = 11;
									continue;
								case 95:
									this.GroupBox1.Size = new Size(435, 112);
									num3 = 49;
									continue;
								case 96:
									this.GroupBox1.TabIndex = 161;
									num3 = 5;
									continue;
								case 97:
									this.GroupBox1.ForeColor = Color.White;
									num3 = 2;
									continue;
								case 98:
									goto IL_6F6;
								}
								break;
							}
						}
						IL_6F6:
						num = -27;
						continue;
					case 5:
						this.txtPhone = new TextBox();
						this.txtLastName = new TextBox();
						this.txtFirstName = new TextBox();
						this.txtID = new TextBox();
						this.Label8 = new Label();
						this.Label6 = new Label();
						this.Label5 = new Label();
						this.Label4 = new Label();
						this.Label3 = new Label();
						this.Label1 = new Label();
						this.GroupBox1 = new GroupBox();
						this.cmdBack = new Button();
						this.cmdEdit = new Button();
						this.cmdSave = new Button();
						num = -26;
						continue;
					case 6:
						this.Label5.AutoSize = true;
						this.Label5.ForeColor = Color.White;
						this.Label5.Location = new Point(71, 257);
						this.Label5.Name = "Label5";
						this.Label5.Size = new Size(91, 17);
						this.Label5.TabIndex = 149;
						this.Label5.Text = "Date of Birth:";
						this.Label4.AutoSize = true;
						this.Label4.ForeColor = Color.White;
						this.Label4.Location = new Point(71, 225);
						this.Label4.Name = "Label4";
						this.Label4.Size = new Size(80, 17);
						this.Label4.TabIndex = 148;
						this.Label4.Text = "Last Name:";
						this.Label3.AutoSize = true;
						num = -29;
						continue;
					case 7:
						this.Label9.AutoSize = true;
						for (;;)
						{
							int num4 = Form6.sbdifomqugmuko(62);
							for (;;)
							{
								num4 ^= 90;
								switch (num4 + 89)
								{
								case 0:
									this.GroupBox3.Size = new Size(327, 54);
									num4 = -10;
									continue;
								case 1:
									this.Label2.AutoSize = true;
									num4 = -13;
									continue;
								case 2:
									this.Label2.Font = new Font("Microsoft Sans Serif", 20f, FontStyle.Regular, GraphicsUnit.Point, 0);
									num4 = -20;
									continue;
								case 3:
									this.Label9.Size = new Size(46, 17);
									num4 = -12;
									continue;
								case 4:
									this.Label9.Name = "Label9";
									num4 = -16;
									continue;
								case 5:
									this.GroupBox3.TabIndex = 170;
									num4 = -22;
									continue;
								case 6:
								{
									RuntimeMethodHandle runtimeMethodHandle3 = methodof(Form8.get_cmdPrevious()).MethodHandle;
									num4 = -9;
									continue;
								}
								case 7:
									this.Label9.TabIndex = 152;
									num4 = -18;
									continue;
								case 8:
									this.Label9.Location = new Point(71, 362);
									num4 = -15;
									continue;
								case 9:
									this.GroupBox3.TabStop = false;
									num4 = -14;
									continue;
								case 10:
									this.GroupBox3.Location = new Point(238, 17);
									num4 = Form12.wsyoqrrjsoniul(41);
									continue;
								case 11:
									this.GroupBox3.Name = "GroupBox3";
									num4 = -3;
									continue;
								case 12:
									this.GroupBox3.Controls.Add(this.Label2);
									num4 = -21;
									continue;
								case 13:
									this.Label9.Text = "Email:";
									num4 = -23;
									continue;
								case 14:
									this.Label9.ForeColor = Color.White;
									num4 = -11;
									continue;
								case 15:
									goto IL_AB7;
								}
								break;
							}
						}
						IL_AB7:
						num = -31;
						continue;
					case 8:
						this.cmdLast.Location = new Point(145, 22);
						this.cmdLast.Name = "cmdLast";
						this.cmdLast.Size = new Size(101, 34);
						this.cmdLast.TabIndex = 118;
						this.cmdLast.Text = "LAST";
						this.cmdLast.UseVisualStyleBackColor = false;
						this.cmdFirst.BackColor = Color.BlueViolet;
						this.cmdFirst.ForeColor = Color.White;
						this.cmdFirst.Location = new Point(28, 22);
						this.cmdFirst.Name = "cmdFirst";
						this.cmdFirst.Size = new Size(101, 34);
						this.cmdFirst.TabIndex = 117;
						this.cmdFirst.Text = "FIRST";
						this.cmdFirst.UseVisualStyleBackColor = false;
						num = -5;
						continue;
					case 9:
						this.lblPassword.Name = "lblPassword";
						this.lblPassword.Size = new Size(73, 17);
						this.lblPassword.TabIndex = 168;
						this.lblPassword.Text = "Password:";
						this.Label10.AutoSize = true;
						this.Label10.ForeColor = Color.White;
						this.Label10.Location = new Point(71, 156);
						this.Label10.Name = "Label10";
						this.Label10.Size = new Size(39, 17);
						this.Label10.TabIndex = 166;
						this.Label10.Text = "Title:";
						this.cboTitle.FormattingEnabled = true;
						this.cboTitle.Location = new Point(170, 153);
						this.cboTitle.Name = "cboTitle";
						this.cboTitle.Size = new Size(310, 24);
						num = -24;
						continue;
					case 10:
						this.cmdSearch = new Button();
						this.GroupBox2 = new GroupBox();
						this.cmdNext = new Button();
						this.cmdPrevious = new Button();
						this.cmdLast = new Button();
						this.cmdFirst = new Button();
						this.Label9 = new Label();
						this.GroupBox3 = new GroupBox();
						this.Label2 = new Label();
						this.OpenFileDialog1 = new OpenFileDialog();
						((ISupportInitialize)this.PictureBox1).BeginInit();
						this.GroupBox1.SuspendLayout();
						this.GroupBox2.SuspendLayout();
						this.GroupBox3.SuspendLayout();
						base.SuspendLayout();
						num = -17;
						continue;
					case 11:
						this.cmdDisplay = new Button();
						this.txtPassword = new TextBox();
						this.lblPassword = new Label();
						this.Label10 = new Label();
						this.cboTitle = new ComboBox();
						this.lblWelcome = new Label();
						this.rbFemale = new RadioButton();
						this.cmdDelete = new Button();
						this.rbMale = new RadioButton();
						this.cmdUpdate = new Button();
						this.cmdPhoto = new Button();
						this.PictureBox1 = new PictureBox();
						this.DateTimePicker1 = new DateTimePicker();
						this.txtEmail = new TextBox();
						this.cmdAdd = new Button();
						num = -3;
						continue;
					case 12:
						this.DateTimePicker1.TabIndex = 158;
						this.DateTimePicker1.Value = new DateTime(2017, 4, 8, 0, 0, 0, 0);
						this.txtEmail.Location = new Point(170, 356);
						this.txtEmail.Name = "txtEmail";
						this.txtEmail.Size = new Size(310, 23);
						this.txtEmail.TabIndex = 157;
						this.cmdAdd.BackColor = Color.BlueViolet;
						this.cmdAdd.Location = new Point(13, 22);
						this.cmdAdd.Name = "cmdAdd";
						this.cmdAdd.Size = new Size(97, 34);
						this.cmdAdd.TabIndex = 62;
						this.cmdAdd.Text = "ADD NEW";
						this.cmdAdd.UseVisualStyleBackColor = false;
						this.txtPhone.Location = new Point(170, 320);
						num = -18;
						continue;
					case 13:
						this.cmdBack.ForeColor = Color.White;
						this.cmdBack.Location = new Point(326, 65);
						this.cmdBack.Name = "cmdBack";
						this.cmdBack.Size = new Size(98, 34);
						this.cmdBack.TabIndex = 84;
						this.cmdBack.Text = "BACK";
						this.cmdBack.UseVisualStyleBackColor = false;
						this.cmdEdit.BackColor = Color.BlueViolet;
						this.cmdEdit.Location = new Point(222, 22);
						this.cmdEdit.Name = "cmdEdit";
						this.cmdEdit.Size = new Size(98, 34);
						this.cmdEdit.TabIndex = 85;
						this.cmdEdit.Text = "EDIT";
						this.cmdEdit.UseVisualStyleBackColor = false;
						num = -15;
						continue;
					case 14:
						this.rbFemale.TabIndex = 163;
						this.rbFemale.TabStop = true;
						this.rbFemale.Text = "Female";
						this.rbFemale.UseVisualStyleBackColor = true;
						this.cmdDelete.BackColor = Color.BlueViolet;
						this.cmdDelete.Location = new Point(13, 65);
						this.cmdDelete.Name = "cmdDelete";
						this.cmdDelete.Size = new Size(97, 34);
						this.cmdDelete.TabIndex = 64;
						this.cmdDelete.Text = "DELETE";
						this.cmdDelete.UseVisualStyleBackColor = false;
						this.rbMale.AutoSize = true;
						this.rbMale.ForeColor = Color.White;
						this.rbMale.Location = new Point(170, 289);
						this.rbMale.Name = "rbMale";
						num = -21;
						continue;
					case 15:
						this.Label3.ForeColor = Color.White;
						this.Label3.Location = new Point(71, 187);
						this.Label3.Name = "Label3";
						this.Label3.Size = new Size(80, 17);
						this.Label3.TabIndex = 147;
						this.Label3.Text = "First Name:";
						this.Label1.AutoSize = true;
						this.Label1.ForeColor = Color.White;
						this.Label1.Location = new Point(71, 123);
						this.Label1.Name = "Label1";
						this.Label1.Size = new Size(68, 17);
						this.Label1.TabIndex = 146;
						this.Label1.Text = "Admin ID:";
						this.GroupBox1.Controls.Add(this.cmdBack);
						num = -4;
						continue;
					case 16:
					{
						RuntimeMethodHandle runtimeMethodHandle4 = methodof(Form8.get_Label8()).MethodHandle;
						num = Form12.wsyoqrrjsoniul(48);
						continue;
					}
					case 17:
						this.Label2.ForeColor = Color.White;
						this.Label2.Location = new Point(13, 13);
						this.Label2.Name = "Label2";
						this.Label2.Size = new Size(308, 31);
						this.Label2.TabIndex = 144;
						this.Label2.Text = "ADMIN PROFILE PAGE";
						this.OpenFileDialog1.FileName = "OpenFileDialog1";
						base.AutoScaleDimensions = new SizeF(8f, 16f);
						base.AutoScaleMode = AutoScaleMode.Font;
						this.BackColor = Color.SteelBlue;
						base.ClientSize = new Size(784, 562);
						base.Controls.Add(this.txtPassword);
						base.Controls.Add(this.lblPassword);
						base.Controls.Add(this.Label10);
						num = -16;
						continue;
					case 18:
						this.txtPhone.Name = "txtPhone";
						this.txtPhone.Size = new Size(310, 23);
						this.txtPhone.TabIndex = 156;
						this.txtLastName.Location = new Point(170, 222);
						this.txtLastName.Name = "txtLastName";
						this.txtLastName.Size = new Size(310, 23);
						this.txtLastName.TabIndex = 155;
						this.txtFirstName.Location = new Point(170, 187);
						this.txtFirstName.Name = "txtFirstName";
						this.txtFirstName.Size = new Size(310, 23);
						this.txtFirstName.TabIndex = 154;
						this.txtID.Location = new Point(170, 120);
						this.txtID.Name = "txtID";
						this.txtID.Size = new Size(310, 23);
						this.txtID.TabIndex = 153;
						num = -20;
						continue;
					case 19:
						this.cmdDisplay.BackColor = Color.BlueViolet;
						this.cmdDisplay.Location = new Point(116, 65);
						this.cmdDisplay.Name = "cmdDisplay";
						this.cmdDisplay.Size = new Size(98, 34);
						this.cmdDisplay.TabIndex = 58;
						this.cmdDisplay.Text = "DISPLAY";
						this.cmdDisplay.UseVisualStyleBackColor = false;
						this.txtPassword.Location = new Point(170, 392);
						this.txtPassword.Name = "txtPassword";
						this.txtPassword.Size = new Size(310, 23);
						this.txtPassword.TabIndex = 169;
						this.lblPassword.AutoSize = true;
						this.lblPassword.ForeColor = Color.White;
						this.lblPassword.Location = new Point(71, 395);
						num = -7;
						continue;
					case 20:
						this.Label8.AutoSize = true;
						this.Label8.ForeColor = Color.White;
						this.Label8.Location = new Point(71, 326);
						this.Label8.Name = "Label8";
						this.Label8.Size = new Size(75, 17);
						this.Label8.TabIndex = 151;
						this.Label8.Text = "Phone No:";
						this.Label6.AutoSize = true;
						this.Label6.ForeColor = Color.White;
						this.Label6.Location = new Point(71, 289);
						this.Label6.Name = "Label6";
						this.Label6.Size = new Size(60, 17);
						this.Label6.TabIndex = 150;
						this.Label6.Text = "Gender:";
						num = -6;
						continue;
					case 21:
						base.Controls.Add(this.Label4);
						base.Controls.Add(this.Label3);
						base.Controls.Add(this.Label1);
						base.Controls.Add(this.GroupBox1);
						base.Controls.Add(this.GroupBox2);
						base.Controls.Add(this.Label9);
						base.Controls.Add(this.GroupBox3);
						this.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
						base.Margin = new Padding(4, 4, 4, 4);
						base.Name = "Form8";
						this.Text = "Form8";
						((ISupportInitialize)this.PictureBox1).EndInit();
						this.GroupBox1.ResumeLayout(false);
						this.GroupBox2.ResumeLayout(false);
						num = -23;
						continue;
					case 22:
						this.cmdPhoto.Location = new Point(546, 276);
						this.cmdPhoto.Name = "cmdPhoto";
						this.cmdPhoto.Size = new Size(138, 31);
						this.cmdPhoto.TabIndex = 160;
						this.cmdPhoto.Text = "UPLOAD PHOTO";
						this.cmdPhoto.UseVisualStyleBackColor = false;
						this.PictureBox1.BackColor = Color.SteelBlue;
						this.PictureBox1.Location = new Point(512, 120);
						this.PictureBox1.Name = "PictureBox1";
						this.PictureBox1.Size = new Size(200, 150);
						this.PictureBox1.TabIndex = 159;
						this.PictureBox1.TabStop = false;
						this.DateTimePicker1.Location = new Point(170, 257);
						this.DateTimePicker1.Name = "DateTimePicker1";
						this.DateTimePicker1.Size = new Size(310, 23);
						num = -28;
						continue;
					case 23:
						this.rbMale.Size = new Size(56, 21);
						this.rbMale.TabIndex = 162;
						this.rbMale.TabStop = true;
						this.rbMale.Text = "Male";
						this.rbMale.UseVisualStyleBackColor = true;
						this.cmdUpdate.BackColor = Color.BlueViolet;
						this.cmdUpdate.Location = new Point(222, 65);
						this.cmdUpdate.Name = "cmdUpdate";
						this.cmdUpdate.Size = new Size(98, 34);
						this.cmdUpdate.TabIndex = 32;
						this.cmdUpdate.Text = "UPDATE";
						this.cmdUpdate.UseVisualStyleBackColor = false;
						this.cmdPhoto.BackColor = Color.BlueViolet;
						this.cmdPhoto.ForeColor = Color.White;
						num = -22;
						continue;
					case 24:
						this.cboTitle.TabIndex = 165;
						this.lblWelcome.AutoSize = true;
						this.lblWelcome.Font = new Font("Microsoft Sans Serif", 16f, FontStyle.Regular, GraphicsUnit.Point, 0);
						this.lblWelcome.ForeColor = Color.White;
						this.lblWelcome.Location = new Point(242, 82);
						this.lblWelcome.Name = "lblWelcome";
						this.lblWelcome.Size = new Size(74, 26);
						this.lblWelcome.TabIndex = 164;
						this.lblWelcome.Text = "Profile";
						this.rbFemale.AutoSize = true;
						this.rbFemale.ForeColor = Color.White;
						this.rbFemale.Location = new Point(408, 289);
						this.rbFemale.Name = "rbFemale";
						this.rbFemale.Size = new Size(72, 21);
						num = -30;
						continue;
					case 25:
						goto IL_1B05;
					}
					break;
				}
			}
			IL_1B05:
			this.GroupBox3.ResumeLayout(false);
			this.GroupBox3.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060001E5 RID: 485 RVA: 0x0001D366 File Offset: 0x0001B566
		// (set) Token: 0x060001E6 RID: 486 RVA: 0x0001D374 File Offset: 0x0001B574
		internal virtual Button cmdDisplay
		{
			[CompilerGenerated]
			get
			{
				return this._cmdDisplay;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.nxfpeikhibypgo);
				Button cmdDisplay = this._cmdDisplay;
				if (cmdDisplay != null)
				{
					cmdDisplay.Click -= value2;
				}
				this._cmdDisplay = value;
				cmdDisplay = this._cmdDisplay;
				if (cmdDisplay != null)
				{
					cmdDisplay.Click += value2;
				}
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060001E7 RID: 487 RVA: 0x0001D3DF File Offset: 0x0001B5DF
		// (set) Token: 0x060001E8 RID: 488 RVA: 0x0001D3ED File Offset: 0x0001B5ED
		internal virtual TextBox txtPassword { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x060001E9 RID: 489 RVA: 0x0001D3FA File Offset: 0x0001B5FA
		// (set) Token: 0x060001EA RID: 490 RVA: 0x0001D408 File Offset: 0x0001B608
		internal virtual Label lblPassword { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x060001EB RID: 491 RVA: 0x0001D415 File Offset: 0x0001B615
		// (set) Token: 0x060001EC RID: 492 RVA: 0x0001D423 File Offset: 0x0001B623
		internal virtual Label Label10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x060001ED RID: 493 RVA: 0x0001D430 File Offset: 0x0001B630
		// (set) Token: 0x060001EE RID: 494 RVA: 0x0001D43E File Offset: 0x0001B63E
		internal virtual ComboBox cboTitle { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x060001EF RID: 495 RVA: 0x0001D44B File Offset: 0x0001B64B
		// (set) Token: 0x060001F0 RID: 496 RVA: 0x0001D459 File Offset: 0x0001B659
		internal virtual Label lblWelcome { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x060001F1 RID: 497 RVA: 0x0001D466 File Offset: 0x0001B666
		// (set) Token: 0x060001F2 RID: 498 RVA: 0x0001D474 File Offset: 0x0001B674
		internal virtual RadioButton rbFemale { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x060001F3 RID: 499 RVA: 0x0001D481 File Offset: 0x0001B681
		// (set) Token: 0x060001F4 RID: 500 RVA: 0x0001D490 File Offset: 0x0001B690
		internal virtual Button cmdDelete
		{
			[CompilerGenerated]
			get
			{
				return this._cmdDelete;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.nxfpeikhibypgm);
				Button cmdDelete = this._cmdDelete;
				if (cmdDelete != null)
				{
					cmdDelete.Click -= value2;
				}
				this._cmdDelete = value;
				cmdDelete = this._cmdDelete;
				if (cmdDelete != null)
				{
					cmdDelete.Click += value2;
				}
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x060001F5 RID: 501 RVA: 0x0001D4FB File Offset: 0x0001B6FB
		// (set) Token: 0x060001F6 RID: 502 RVA: 0x0001D509 File Offset: 0x0001B709
		internal virtual RadioButton rbMale { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x060001F7 RID: 503 RVA: 0x0001D516 File Offset: 0x0001B716
		// (set) Token: 0x060001F8 RID: 504 RVA: 0x0001D524 File Offset: 0x0001B724
		internal virtual Button cmdUpdate
		{
			[CompilerGenerated]
			get
			{
				return this._cmdUpdate;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.nxfpeikhibypgn);
				Button cmdUpdate = this._cmdUpdate;
				if (cmdUpdate != null)
				{
					cmdUpdate.Click -= value2;
				}
				this._cmdUpdate = value;
				cmdUpdate = this._cmdUpdate;
				if (cmdUpdate != null)
				{
					cmdUpdate.Click += value2;
				}
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x060001F9 RID: 505 RVA: 0x0001D58F File Offset: 0x0001B78F
		// (set) Token: 0x060001FA RID: 506 RVA: 0x0001D5A0 File Offset: 0x0001B7A0
		internal virtual Button cmdPhoto
		{
			[CompilerGenerated]
			get
			{
				return this._cmdPhoto;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.nxfpeikhibypgf);
				Button cmdPhoto = this._cmdPhoto;
				if (cmdPhoto != null)
				{
					cmdPhoto.Click -= value2;
				}
				this._cmdPhoto = value;
				cmdPhoto = this._cmdPhoto;
				if (cmdPhoto != null)
				{
					cmdPhoto.Click += value2;
				}
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x060001FB RID: 507 RVA: 0x0001D60B File Offset: 0x0001B80B
		// (set) Token: 0x060001FC RID: 508 RVA: 0x0001D619 File Offset: 0x0001B819
		internal virtual PictureBox PictureBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x060001FD RID: 509 RVA: 0x0001D626 File Offset: 0x0001B826
		// (set) Token: 0x060001FE RID: 510 RVA: 0x0001D634 File Offset: 0x0001B834
		internal virtual DateTimePicker DateTimePicker1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x060001FF RID: 511 RVA: 0x0001D641 File Offset: 0x0001B841
		// (set) Token: 0x06000200 RID: 512 RVA: 0x0001D64F File Offset: 0x0001B84F
		internal virtual TextBox txtEmail { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x06000201 RID: 513 RVA: 0x0001D65C File Offset: 0x0001B85C
		// (set) Token: 0x06000202 RID: 514 RVA: 0x0001D66C File Offset: 0x0001B86C
		internal virtual Button cmdAdd
		{
			[CompilerGenerated]
			get
			{
				return this._cmdAdd;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.nxfpeikhibypgg);
				Button cmdAdd = this._cmdAdd;
				if (cmdAdd != null)
				{
					cmdAdd.Click -= value2;
				}
				this._cmdAdd = value;
				cmdAdd = this._cmdAdd;
				if (cmdAdd != null)
				{
					cmdAdd.Click += value2;
				}
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x06000203 RID: 515 RVA: 0x0001D6D7 File Offset: 0x0001B8D7
		// (set) Token: 0x06000204 RID: 516 RVA: 0x0001D6E5 File Offset: 0x0001B8E5
		internal virtual TextBox txtPhone { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x06000205 RID: 517 RVA: 0x0001D6F2 File Offset: 0x0001B8F2
		// (set) Token: 0x06000206 RID: 518 RVA: 0x0001D700 File Offset: 0x0001B900
		internal virtual TextBox txtLastName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x06000207 RID: 519 RVA: 0x0001D70D File Offset: 0x0001B90D
		// (set) Token: 0x06000208 RID: 520 RVA: 0x0001D71B File Offset: 0x0001B91B
		internal virtual TextBox txtFirstName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x06000209 RID: 521 RVA: 0x0001D728 File Offset: 0x0001B928
		// (set) Token: 0x0600020A RID: 522 RVA: 0x0001D736 File Offset: 0x0001B936
		internal virtual TextBox txtID { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x0600020B RID: 523 RVA: 0x0001D743 File Offset: 0x0001B943
		// (set) Token: 0x0600020C RID: 524 RVA: 0x0001D751 File Offset: 0x0001B951
		internal virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x0600020D RID: 525 RVA: 0x0001D75E File Offset: 0x0001B95E
		// (set) Token: 0x0600020E RID: 526 RVA: 0x0001D76C File Offset: 0x0001B96C
		internal virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x0600020F RID: 527 RVA: 0x0001D779 File Offset: 0x0001B979
		// (set) Token: 0x06000210 RID: 528 RVA: 0x0001D787 File Offset: 0x0001B987
		internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x06000211 RID: 529 RVA: 0x0001D794 File Offset: 0x0001B994
		// (set) Token: 0x06000212 RID: 530 RVA: 0x0001D7A2 File Offset: 0x0001B9A2
		internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x06000213 RID: 531 RVA: 0x0001D7AF File Offset: 0x0001B9AF
		// (set) Token: 0x06000214 RID: 532 RVA: 0x0001D7BD File Offset: 0x0001B9BD
		internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x06000215 RID: 533 RVA: 0x0001D7CA File Offset: 0x0001B9CA
		// (set) Token: 0x06000216 RID: 534 RVA: 0x0001D7D8 File Offset: 0x0001B9D8
		internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x06000217 RID: 535 RVA: 0x0001D7E5 File Offset: 0x0001B9E5
		// (set) Token: 0x06000218 RID: 536 RVA: 0x0001D7F3 File Offset: 0x0001B9F3
		internal virtual GroupBox GroupBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x06000219 RID: 537 RVA: 0x0001D800 File Offset: 0x0001BA00
		// (set) Token: 0x0600021A RID: 538 RVA: 0x0001D810 File Offset: 0x0001BA10
		internal virtual Button cmdBack
		{
			[CompilerGenerated]
			get
			{
				return this._cmdBack;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.nxfpeikhibypgq);
				Button cmdBack = this._cmdBack;
				if (cmdBack != null)
				{
					cmdBack.Click -= value2;
				}
				this._cmdBack = value;
				cmdBack = this._cmdBack;
				if (cmdBack != null)
				{
					cmdBack.Click += value2;
				}
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x0600021B RID: 539 RVA: 0x0001D87B File Offset: 0x0001BA7B
		// (set) Token: 0x0600021C RID: 540 RVA: 0x0001D88C File Offset: 0x0001BA8C
		internal virtual Button cmdEdit
		{
			[CompilerGenerated]
			get
			{
				return this._cmdEdit;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.nxfpeikhibypgr);
				Button cmdEdit = this._cmdEdit;
				if (cmdEdit != null)
				{
					cmdEdit.Click -= value2;
				}
				this._cmdEdit = value;
				cmdEdit = this._cmdEdit;
				if (cmdEdit != null)
				{
					cmdEdit.Click += value2;
				}
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x0600021D RID: 541 RVA: 0x0001D8F7 File Offset: 0x0001BAF7
		// (set) Token: 0x0600021E RID: 542 RVA: 0x0001D908 File Offset: 0x0001BB08
		internal virtual Button cmdSave
		{
			[CompilerGenerated]
			get
			{
				return this._cmdSave;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.nxfpeikhibypgh);
				Button cmdSave = this._cmdSave;
				if (cmdSave != null)
				{
					cmdSave.Click -= value2;
				}
				this._cmdSave = value;
				cmdSave = this._cmdSave;
				if (cmdSave != null)
				{
					cmdSave.Click += value2;
				}
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x0600021F RID: 543 RVA: 0x0001D973 File Offset: 0x0001BB73
		// (set) Token: 0x06000220 RID: 544 RVA: 0x0001D984 File Offset: 0x0001BB84
		internal virtual Button cmdSearch
		{
			[CompilerGenerated]
			get
			{
				return this._cmdSearch;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.nxfpeikhibypgp);
				Button cmdSearch = this._cmdSearch;
				if (cmdSearch != null)
				{
					cmdSearch.Click -= value2;
				}
				this._cmdSearch = value;
				cmdSearch = this._cmdSearch;
				if (cmdSearch != null)
				{
					cmdSearch.Click += value2;
				}
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x06000221 RID: 545 RVA: 0x0001D9EF File Offset: 0x0001BBEF
		// (set) Token: 0x06000222 RID: 546 RVA: 0x0001D9FD File Offset: 0x0001BBFD
		internal virtual GroupBox GroupBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x06000223 RID: 547 RVA: 0x0001DA0A File Offset: 0x0001BC0A
		// (set) Token: 0x06000224 RID: 548 RVA: 0x0001DA18 File Offset: 0x0001BC18
		internal virtual Button cmdNext
		{
			[CompilerGenerated]
			get
			{
				return this._cmdNext;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.nxfpeikhibypgk);
				Button cmdNext = this._cmdNext;
				if (cmdNext != null)
				{
					cmdNext.Click -= value2;
				}
				this._cmdNext = value;
				cmdNext = this._cmdNext;
				if (cmdNext != null)
				{
					cmdNext.Click += value2;
				}
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x06000225 RID: 549 RVA: 0x0001DA83 File Offset: 0x0001BC83
		// (set) Token: 0x06000226 RID: 550 RVA: 0x0001DA94 File Offset: 0x0001BC94
		internal virtual Button cmdPrevious
		{
			[CompilerGenerated]
			get
			{
				return this._cmdPrevious;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.nxfpeikhibypgl);
				Button cmdPrevious = this._cmdPrevious;
				if (cmdPrevious != null)
				{
					cmdPrevious.Click -= value2;
				}
				this._cmdPrevious = value;
				cmdPrevious = this._cmdPrevious;
				if (cmdPrevious != null)
				{
					cmdPrevious.Click += value2;
				}
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x06000227 RID: 551 RVA: 0x0001DAFF File Offset: 0x0001BCFF
		// (set) Token: 0x06000228 RID: 552 RVA: 0x0001DB10 File Offset: 0x0001BD10
		internal virtual Button cmdLast
		{
			[CompilerGenerated]
			get
			{
				return this._cmdLast;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.nxfpeikhibypgj);
				Button cmdLast = this._cmdLast;
				if (cmdLast != null)
				{
					cmdLast.Click -= value2;
				}
				this._cmdLast = value;
				cmdLast = this._cmdLast;
				if (cmdLast != null)
				{
					cmdLast.Click += value2;
				}
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06000229 RID: 553 RVA: 0x0001DB7B File Offset: 0x0001BD7B
		// (set) Token: 0x0600022A RID: 554 RVA: 0x0001DB8C File Offset: 0x0001BD8C
		internal virtual Button cmdFirst
		{
			[CompilerGenerated]
			get
			{
				return this._cmdFirst;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.nxfpeikhibypgi);
				Button cmdFirst = this._cmdFirst;
				if (cmdFirst != null)
				{
					cmdFirst.Click -= value2;
				}
				this._cmdFirst = value;
				cmdFirst = this._cmdFirst;
				if (cmdFirst != null)
				{
					cmdFirst.Click += value2;
				}
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x0600022B RID: 555 RVA: 0x0001DBF7 File Offset: 0x0001BDF7
		// (set) Token: 0x0600022C RID: 556 RVA: 0x0001DC05 File Offset: 0x0001BE05
		internal virtual Label Label9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x0600022D RID: 557 RVA: 0x0001DC12 File Offset: 0x0001BE12
		// (set) Token: 0x0600022E RID: 558 RVA: 0x0001DC20 File Offset: 0x0001BE20
		internal virtual GroupBox GroupBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x0600022F RID: 559 RVA: 0x0001DC2D File Offset: 0x0001BE2D
		// (set) Token: 0x06000230 RID: 560 RVA: 0x0001DC3B File Offset: 0x0001BE3B
		internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06000231 RID: 561 RVA: 0x0001DC48 File Offset: 0x0001BE48
		// (set) Token: 0x06000232 RID: 562 RVA: 0x0001DC56 File Offset: 0x0001BE56
		internal virtual OpenFileDialog OpenFileDialog1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x06000233 RID: 563 RVA: 0x0001DC64 File Offset: 0x0001BE64
		private void nxfpeikhibypge(object dc, EventArgs dd)
		{
			for (;;)
			{
				IL_C4:
				int num = 18;
				int num2 = Form2.uwpnsrqhswlmjh(42);
				for (;;)
				{
					num2 ^= 83;
					for (;;)
					{
						IL_3D:
						int num3 = 0;
						int num4 = 8;
						for (;;)
						{
							switch (num4 ^ 91)
							{
							case 80:
								goto IL_3D;
							case 81:
							{
								RuntimeMethodHandle runtimeMethodHandle = methodof(Form8.get_Label10()).MethodHandle;
								num4 = 10;
								continue;
							}
							case 82:
								switch (num3)
								{
								case 89:
									switch (num2 + 84)
									{
									case 0:
										goto IL_B7;
									case 1:
										goto IL_C4;
									case 2:
										switch (num)
										{
										case 87:
											num = 43;
											goto IL_0B;
										case 88:
											num = 20;
											goto IL_0B;
										case 89:
											this.cboTitle.Items.Add("Mr.");
											num = 19;
											goto IL_0B;
										case 90:
											this.cboTitle.Items.Add("Dr.");
											num = 22;
											goto IL_0B;
										case 91:
											this.display();
											num = 42;
											goto IL_0B;
										case 92:
											this.cboTitle.Items.Add("Mrs.");
											num = 41;
											goto IL_0B;
										case 93:
											this.cboTitle.Items.Add("Prof.");
											num = 21;
											goto IL_0B;
										case 94:
											this.con.Open("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\\Users\\Joey\\Documents\\College.mdb; Persist Security Info = False", "", "", -1);
											num = 46;
											goto IL_0B;
										case 95:
										{
											RuntimeMethodHandle runtimeMethodHandle2 = methodof(Form8.get_GroupBox1()).MethodHandle;
											num = 16;
											goto IL_0B;
										}
										case 96:
											this.rs.Open("Select * from AdminsProfile", this.con, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
											num = 24;
											goto IL_0B;
										case 97:
											num = 47;
											goto IL_0B;
										case 98:
										{
											string str;
											this.lblWelcome.Text = str + "'s " + this.lblWelcome.Text;
											num = 23;
											goto IL_0B;
										}
										case 99:
											this.cboTitle.Items.Add("Ms");
											num = 17;
											goto IL_0B;
										case 100:
										{
											string str = Conversions.ToString(this.rs.Fields["FirstName"].Value);
											num = 45;
											goto IL_0B;
										}
										case 101:
											num = 40;
											goto IL_0B;
										case 102:
											this.cboTitle.Items.Add("Miss");
											num = 44;
											goto IL_0B;
										case 103:
											return;
										}
										goto Block_3;
									case 3:
										break;
									default:
										num3 = 3;
										goto IL_1C;
									}
									IL_0B:
									num ^= 79;
									break;
								case 90:
									break;
								case 91:
								{
									RuntimeMethodHandle runtimeMethodHandle3 = methodof(Form8.get_GroupBox2()).MethodHandle;
									num3 = 2;
									goto IL_1C;
								}
								case 92:
									goto IL_B2;
								default:
									num4 = 11;
									continue;
								}
								num2 = Form7.mqgfoefwabbyeu(31);
								num3 = 5;
								goto IL_1C;
							case 83:
								goto IL_1C;
							}
							IL_37:
							num4 = 9;
							continue;
							IL_1C:
							num3 ^= 89;
							goto IL_37;
						}
					}
					IL_B2:
					continue;
					IL_B7:
					RuntimeMethodHandle runtimeMethodHandle4 = methodof(Form8.nxfpeikhibypgo(object, EventArgs)).MethodHandle;
					num2 = -1;
					continue;
					Block_3:
					num2 = -2;
				}
			}
		}

		// Token: 0x06000234 RID: 564 RVA: 0x0001DF60 File Offset: 0x0001C160
		private void nxfpeikhibypgf(object de, EventArgs df)
		{
			for (;;)
			{
				IL_F0:
				int num = Form7.mqgfoefwabbyeu(25);
				int num2 = Form2.uwpnsrqhswlmjh(47);
				for (;;)
				{
					num2 ^= 85;
					for (;;)
					{
						IL_4E:
						int num3 = 8;
						int num4 = Form7.mqgfoefwabbyeu(24);
						for (;;)
						{
							num4 ^= 79;
							switch (num4 + 82)
							{
							case 0:
							{
								RuntimeMethodHandle runtimeMethodHandle = methodof(Form8.set_cmdSave(Button)).MethodHandle;
								num4 = -31;
								continue;
							}
							case 1:
								goto IL_4E;
							case 2:
								switch (num3)
								{
								case 88:
								{
									RuntimeMethodHandle runtimeMethodHandle2 = methodof(Form8.set_txtLastName(TextBox)).MethodHandle;
									num3 = 9;
									goto IL_1C;
								}
								case 89:
									switch (num2 + 79)
									{
									case 0:
										switch (num + 89)
										{
										case 0:
											num = -6;
											goto IL_0B;
										case 1:
											this.OpenFileDialog1.ShowDialog();
											num = Form2.uwpnsrqhswlmjh(42);
											goto IL_0B;
										case 2:
											this.PictureBox1.Image = Image.FromFile(this.str);
											num = -3;
											goto IL_0B;
										case 3:
											num = -7;
											goto IL_0B;
										case 4:
											this.OpenFileDialog1.Filter = "Jpeg | *.jpg";
											num = -16;
											goto IL_0B;
										case 5:
										{
											RuntimeMethodHandle runtimeMethodHandle3 = methodof(Form8.get_cmdNext()).MethodHandle;
											num = -5;
											goto IL_0B;
										}
										case 6:
											this.str = this.OpenFileDialog1.FileName;
											num = -2;
											goto IL_0B;
										case 7:
											return;
										}
										goto Block_3;
									case 1:
										goto IL_F0;
									case 2:
										goto IL_105;
									case 3:
										break;
									default:
										num3 = 11;
										goto IL_1C;
									}
									IL_0B:
									num ^= 87;
									break;
								case 90:
									break;
								case 91:
									goto IL_BA;
								default:
									num4 = -32;
									continue;
								}
								num2 = Form12.wsyoqrrjsoniul(54);
								num3 = 10;
								goto IL_1C;
							case 3:
								goto IL_1C;
							}
							IL_35:
							num4 = Form7.mqgfoefwabbyeu(25);
							continue;
							IL_1C:
							num3 ^= 81;
							goto IL_35;
						}
					}
					IL_BA:
					continue;
					Block_3:
					num2 = -25;
					continue;
					IL_105:
					RuntimeMethodHandle runtimeMethodHandle4 = methodof(Form8.set_Label2(Label)).MethodHandle;
					num2 = -26;
				}
			}
		}

		// Token: 0x06000235 RID: 565 RVA: 0x0001E144 File Offset: 0x0001C344
		private void nxfpeikhibypgg(object dg, EventArgs dh)
		{
			for (;;)
			{
				IL_B2:
				int num = Form12.wsyoqrrjsoniul(43);
				int num2 = Form12.wsyoqrrjsoniul(54);
				for (;;)
				{
					num2 ^= 86;
					for (;;)
					{
						IL_47:
						int num3 = 22;
						int num4 = 0;
						for (;;)
						{
							switch (num4 ^ 91)
							{
							case 88:
							{
								RuntimeMethodHandle runtimeMethodHandle = methodof(Form8.set_cboTitle(ComboBox)).MethodHandle;
								num4 = 3;
								continue;
							}
							case 89:
								goto IL_47;
							case 90:
								switch (num3)
								{
								case 89:
									switch (num2 + 81)
									{
									case 0:
										goto IL_B2;
									case 1:
										goto IL_C7;
									case 2:
										switch (num + 88)
										{
										case 0:
											this.lblPassword.Visible = true;
											num = -11;
											goto IL_0B;
										case 1:
											num = -14;
											goto IL_0B;
										case 2:
											this.clear();
											num = -12;
											goto IL_0B;
										case 3:
											this.txtPassword.Visible = true;
											num = Form12.wsyoqrrjsoniul(41);
											goto IL_0B;
										case 4:
											num = -9;
											goto IL_0B;
										case 5:
											num = -13;
											goto IL_0B;
										case 6:
										{
											RuntimeMethodHandle runtimeMethodHandle2 = methodof(Form8.refreshData()).MethodHandle;
											num = -10;
											goto IL_0B;
										}
										case 7:
											this.PictureBox1.BorderStyle = BorderStyle.FixedSingle;
											num = -23;
											goto IL_0B;
										case 8:
											num = -21;
											goto IL_0B;
										case 9:
											num = -16;
											goto IL_0B;
										case 10:
											this.rs.AddNew(RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value));
											num = -15;
											goto IL_0B;
										case 11:
											return;
										}
										goto Block_3;
									case 3:
										break;
									default:
										num3 = 20;
										goto IL_1C;
									}
									IL_0B:
									num ^= 88;
									break;
								case 90:
								{
									RuntimeMethodHandle runtimeMethodHandle3 = methodof(Form8.get_GroupBox1()).MethodHandle;
									num3 = 21;
									goto IL_1C;
								}
								case 91:
									break;
								case 92:
									goto IL_AD;
								default:
									num4 = 2;
									continue;
								}
								num2 = Form2.uwpnsrqhswlmjh(50);
								num3 = 19;
								goto IL_1C;
							case 91:
								goto IL_1C;
							}
							IL_35:
							num4 = 1;
							continue;
							IL_1C:
							num3 ^= 79;
							goto IL_35;
						}
					}
					IL_AD:
					continue;
					IL_C7:
					RuntimeMethodHandle runtimeMethodHandle4 = methodof(Form8.get_cmdUpdate()).MethodHandle;
					num2 = -26;
					continue;
					Block_3:
					num2 = -7;
				}
			}
		}

		// Token: 0x06000236 RID: 566 RVA: 0x0001E354 File Offset: 0x0001C554
		public void clear()
		{
			for (;;)
			{
				IL_144:
				int num = Form12.wsyoqrrjsoniul(52);
				int num2 = 7;
				for (;;)
				{
					num2 ^= 88;
					for (;;)
					{
						IL_4E:
						int num3 = Form12.wsyoqrrjsoniul(52);
						int num4 = Form12.wsyoqrrjsoniul(40);
						for (;;)
						{
							num4 ^= 84;
							switch (num4 + 87)
							{
							case 0:
							{
								RuntimeMethodHandle runtimeMethodHandle = methodof(Form8..ctor()).MethodHandle;
								num4 = -3;
								continue;
							}
							case 1:
								goto IL_4E;
							case 2:
								switch (num3 + 79)
								{
								case 0:
									switch (num2)
									{
									case 92:
										goto IL_C7;
									case 93:
										switch (num + 89)
										{
										case 0:
											num = -24;
											goto IL_0B;
										case 1:
											num = -9;
											goto IL_0B;
										case 2:
											this.cboTitle.Text = "";
											num = -21;
											goto IL_0B;
										case 3:
											num = -18;
											goto IL_0B;
										case 4:
											num = -19;
											goto IL_0B;
										case 5:
											num = -30;
											goto IL_0B;
										case 6:
											num = -10;
											goto IL_0B;
										case 7:
											this.txtLastName.Text = "";
											num = -22;
											goto IL_0B;
										case 8:
											this.rbFemale.Checked = false;
											num = -2;
											goto IL_0B;
										case 9:
											this.DateTimePicker1.Value = DateTime.Today;
											num = -14;
											goto IL_0B;
										case 10:
											this.txtPhone.Text = "";
											num = -13;
											goto IL_0B;
										case 11:
											num = -20;
											goto IL_0B;
										case 12:
											num = Form2.uwpnsrqhswlmjh(45);
											goto IL_0B;
										case 13:
											this.rbMale.Checked = false;
											num = -12;
											goto IL_0B;
										case 14:
											this.txtFirstName.Text = "";
											num = -15;
											goto IL_0B;
										case 15:
											num = -25;
											goto IL_0B;
										case 16:
											this.txtEmail.Text = "";
											num = -11;
											goto IL_0B;
										case 17:
											num = -28;
											goto IL_0B;
										case 18:
											num = -16;
											goto IL_0B;
										case 19:
											this.txtID.Text = "";
											num = -32;
											goto IL_0B;
										case 20:
											this.PictureBox1.Image = null;
											num = -31;
											goto IL_0B;
										case 21:
										{
											RuntimeMethodHandle runtimeMethodHandle2 = methodof(Form8.get_cmdLast()).MethodHandle;
											num = -27;
											goto IL_0B;
										}
										case 22:
											this.txtPassword.Text = "";
											num = -17;
											goto IL_0B;
										case 23:
											return;
										}
										goto Block_3;
									case 94:
										goto IL_144;
									case 95:
										break;
									default:
										num3 = -32;
										goto IL_1C;
									}
									IL_0B:
									num ^= 89;
									break;
								case 1:
									break;
								case 2:
								{
									RuntimeMethodHandle runtimeMethodHandle3 = methodof(Form8.set_cmdEdit(Button)).MethodHandle;
									num3 = Form2.uwpnsrqhswlmjh(47);
									goto IL_1C;
								}
								case 3:
									goto IL_C2;
								default:
									num4 = -2;
									continue;
								}
								num2 = 5;
								num3 = -26;
								goto IL_1C;
							case 3:
								goto IL_1C;
							}
							IL_35:
							num4 = Form7.mqgfoefwabbyeu(25);
							continue;
							IL_1C:
							num3 ^= 82;
							goto IL_35;
						}
					}
					IL_C2:
					continue;
					IL_C7:
					RuntimeMethodHandle runtimeMethodHandle4 = methodof(Form8.set_cmdFirst(Button)).MethodHandle;
					num2 = 4;
					continue;
					Block_3:
					num2 = 6;
				}
			}
		}

		// Token: 0x06000237 RID: 567 RVA: 0x0001E660 File Offset: 0x0001C860
		public void display()
		{
			for (;;)
			{
				IL_C7:
				int num = 60;
				int num2 = Form12.wsyoqrrjsoniul(41);
				for (;;)
				{
					num2 ^= 79;
					for (;;)
					{
						int num3 = Form2.uwpnsrqhswlmjh(44);
						for (;;)
						{
							num3 ^= 83;
							switch (num3 + 87)
							{
							case 0:
								switch (num2 + 92)
								{
								case 0:
									switch (num)
									{
									case 89:
										this.txtFirstName.Text = Conversions.ToString(this.rs.Fields["FirstName"].Value);
										num = 56;
										goto IL_0B;
									case 90:
										this.cboTitle.Text = Conversions.ToString(this.rs.Fields["Title"].Value);
										num = 59;
										goto IL_0B;
									case 91:
									{
										bool flag = Operators.ConditionalCompareObjectEqual(this.rs.Fields["Gender"].Value, this.rbMale.Text, false);
										num = 57;
										goto IL_0B;
									}
									case 92:
									{
										RuntimeMethodHandle runtimeMethodHandle = methodof(Form8.set_rbMale(RadioButton)).MethodHandle;
										num = 4;
										goto IL_0B;
									}
									case 93:
										num = 2;
										goto IL_0B;
									case 94:
										num = 3;
										goto IL_0B;
									case 95:
										num = 58;
										goto IL_0B;
									case 96:
										num = 61;
										goto IL_0B;
									case 97:
									{
										bool flag;
										if (flag)
										{
											num = 62;
											goto IL_0B;
										}
										goto IL_250;
									}
									case 98:
										this.DateTimePicker1.Value = Conversions.ToDate(this.rs.Fields["DOB"].Value);
										num = 6;
										goto IL_0B;
									case 99:
										num = 1;
										goto IL_0B;
									case 100:
										this.txtID.Text = Conversions.ToString(this.rs.Fields["AdminID"].Value);
										num = 5;
										goto IL_0B;
									case 101:
										this.txtLastName.Text = Conversions.ToString(this.rs.Fields["LastName"].Value);
										num = 7;
										goto IL_0B;
									case 102:
										goto IL_24D;
									}
									goto Block_1;
								case 1:
									goto IL_B8;
								case 2:
									goto IL_C7;
								case 3:
									break;
								default:
									num3 = Form12.wsyoqrrjsoniul(51);
									continue;
								}
								IL_0B:
								num ^= 88;
								goto IL_4F;
							case 1:
								goto IL_4F;
							case 2:
							{
								RuntimeMethodHandle runtimeMethodHandle2 = methodof(Form8.get_cmdAdd()).MethodHandle;
								num3 = -8;
								continue;
							}
							case 3:
								goto IL_6C;
							}
							break;
							IL_4F:
							num2 = Form6.sbdifomqugmuko(57);
							num3 = -1;
						}
					}
					IL_6C:
					continue;
					Block_1:
					num2 = -23;
					continue;
					IL_B8:
					RuntimeMethodHandle runtimeMethodHandle3 = methodof(Form8.get_rbMale()).MethodHandle;
					num2 = -22;
				}
			}
			IL_24D:
			bool flag2 = false;
			goto IL_253;
			IL_250:
			flag2 = true;
			IL_253:
			if (!flag2)
			{
				this.rbMale.Checked = true;
			}
			else
			{
				bool flag3 = Operators.ConditionalCompareObjectEqual(this.rs.Fields["Gender"].Value, this.rbFemale.Text, false);
				if (flag3)
				{
					this.rbFemale.Checked = true;
				}
			}
			this.txtPhone.Text = Conversions.ToString(this.rs.Fields["PhoneNo"].Value);
			for (;;)
			{
				int num4 = Form7.mqgfoefwabbyeu(25);
				for (;;)
				{
					num4 ^= 86;
					switch (num4 + 92)
					{
					case 0:
						num4 = -3;
						continue;
					case 1:
					{
						RuntimeMethodHandle runtimeMethodHandle4 = methodof(Form8.set_cmdLast(Button)).MethodHandle;
						num4 = -13;
						continue;
					}
					case 2:
						this.PictureBox1.Image = Image.FromFile(Conversions.ToString(this.rs.Fields["Photo"].Value));
						num4 = -14;
						continue;
					case 3:
						num4 = -16;
						continue;
					case 4:
						this.lblPassword.Visible = false;
						num4 = -4;
						continue;
					case 5:
						num4 = -5;
						continue;
					case 6:
						num4 = -8;
						continue;
					case 7:
						this.txtPassword.Text = Conversions.ToString(this.rs.Fields["Password"].Value);
						num4 = -6;
						continue;
					case 8:
						num4 = -2;
						continue;
					case 9:
						this.txtEmail.Text = Conversions.ToString(this.rs.Fields["Email"].Value);
						num4 = -15;
						continue;
					case 10:
						this.txtPassword.Visible = false;
						num4 = Form12.wsyoqrrjsoniul(51);
						continue;
					case 11:
						num4 = -26;
						continue;
					case 12:
						return;
					}
					break;
				}
			}
		}

		// Token: 0x06000238 RID: 568 RVA: 0x0001EAE0 File Offset: 0x0001CCE0
		public void refreshData()
		{
			for (;;)
			{
				IL_BA:
				int num = Form12.wsyoqrrjsoniul(52);
				int num2 = -22;
				for (;;)
				{
					num2 ^= 89;
					for (;;)
					{
						int num3 = 12;
						for (;;)
						{
							switch (num3 ^ 87)
							{
							case 89:
							{
								RuntimeMethodHandle runtimeMethodHandle = methodof(Form8.nxfpeikhibypgh(object, EventArgs)).MethodHandle;
								num3 = 14;
								continue;
							}
							case 90:
								goto IL_43;
							case 91:
								switch (num2 + 80)
								{
								case 0:
									switch (num + 80)
									{
									case 0:
										num = -32;
										goto IL_0B;
									case 1:
									{
										bool flag;
										if (flag)
										{
											num = -30;
											goto IL_0B;
										}
										goto IL_14D;
									}
									case 2:
									{
										RuntimeMethodHandle runtimeMethodHandle2 = methodof(Form8.set_txtID(TextBox)).MethodHandle;
										num = -25;
										goto IL_0B;
									}
									case 3:
										this.rs.Open("Select * from AdminsProfile", this.con, CursorTypeEnum.adOpenStatic, LockTypeEnum.adLockPessimistic, -1);
										num = -27;
										goto IL_0B;
									case 4:
										num = -26;
										goto IL_0B;
									case 5:
									{
										bool flag = !this.rs.EOF;
										num = -28;
										goto IL_0B;
									}
									case 6:
										this.rs.Close();
										num = Form2.uwpnsrqhswlmjh(47);
										goto IL_0B;
									case 7:
										goto IL_14A;
									}
									goto Block_2;
								case 1:
									goto IL_AC;
								case 2:
									goto IL_BA;
								case 3:
									break;
								default:
									num3 = 13;
									continue;
								}
								IL_0B:
								num ^= 85;
								goto IL_43;
							case 92:
								goto IL_74;
							}
							break;
							IL_43:
							num2 = Form2.uwpnsrqhswlmjh(45);
							num3 = 11;
						}
					}
					IL_74:
					continue;
					Block_2:
					num2 = Form6.sbdifomqugmuko(57);
					continue;
					IL_AC:
					RuntimeMethodHandle runtimeMethodHandle3 = methodof(Form8.reload()).MethodHandle;
					num2 = -24;
				}
			}
			IL_14A:
			bool flag2 = false;
			goto IL_150;
			IL_14D:
			flag2 = true;
			IL_150:
			if (!flag2)
			{
				this.rs.MoveNext();
				for (;;)
				{
					int num4 = Form7.mqgfoefwabbyeu(21);
					for (;;)
					{
						num4 ^= 85;
						switch (num4 + 90)
						{
						case 0:
							num4 = -1;
							continue;
						case 1:
							num4 = -3;
							continue;
						case 2:
							num4 = -2;
							continue;
						case 3:
						{
							RuntimeMethodHandle runtimeMethodHandle4 = methodof(Form8.get_DateTimePicker1()).MethodHandle;
							num4 = -4;
							continue;
						}
						case 4:
							this.display();
							num4 = Form12.wsyoqrrjsoniul(53);
							continue;
						case 5:
							goto IL_1ED;
						}
						break;
					}
				}
				IL_1ED:;
			}
			else
			{
				Interaction.MsgBox("Record Not Found.", MsgBoxStyle.Information, null);
			}
		}

		// Token: 0x06000239 RID: 569 RVA: 0x0001ECF8 File Offset: 0x0001CEF8
		public void reload()
		{
			for (;;)
			{
				IL_B6:
				int num = 14;
				int num2 = 9;
				for (;;)
				{
					num2 ^= 81;
					for (;;)
					{
						IL_56:
						int num3 = 1;
						int num4 = 13;
						for (;;)
						{
							switch (num4 ^ 91)
							{
							case 83:
								switch (num3)
								{
								case 81:
								{
									RuntimeMethodHandle runtimeMethodHandle = methodof(Form8.get_cmdNext()).MethodHandle;
									num3 = 2;
									goto IL_1C;
								}
								case 82:
									switch (num2)
									{
									case 85:
										switch (num)
										{
										case 86:
											num = 0;
											goto IL_0B;
										case 87:
											this.rs.Open("Select * from AdminsProfile", this.con, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
											num = 15;
											goto IL_0B;
										case 88:
											num = 12;
											goto IL_0B;
										case 89:
											this.rs.Close();
											num = 1;
											goto IL_0B;
										case 90:
										{
											RuntimeMethodHandle runtimeMethodHandle2 = methodof(Form8.nxfpeikhibypgr(object, EventArgs)).MethodHandle;
											num = 13;
											goto IL_0B;
										}
										case 91:
											return;
										}
										goto Block_2;
									case 86:
										goto IL_B6;
									case 87:
										goto IL_C1;
									case 88:
										break;
									default:
										num3 = 0;
										goto IL_1C;
									}
									IL_0B:
									num ^= 87;
									break;
								case 83:
									break;
								case 84:
									goto IL_8C;
								default:
									num4 = 14;
									continue;
								}
								num2 = 4;
								num3 = 7;
								goto IL_1C;
							case 84:
							{
								RuntimeMethodHandle runtimeMethodHandle3 = methodof(Form8.nxfpeikhibypgq(object, EventArgs)).MethodHandle;
								num4 = 15;
								continue;
							}
							case 85:
								goto IL_56;
							case 86:
								goto IL_1C;
							}
							IL_35:
							num4 = 8;
							continue;
							IL_1C:
							num3 ^= 83;
							goto IL_35;
						}
					}
					IL_8C:
					continue;
					Block_2:
					num2 = 7;
					continue;
					IL_C1:
					RuntimeMethodHandle runtimeMethodHandle4 = methodof(Form8.nxfpeikhibypgh(object, EventArgs)).MethodHandle;
					num2 = 6;
				}
			}
		}

		// Token: 0x0600023A RID: 570 RVA: 0x0001EE70 File Offset: 0x0001D070
		private void nxfpeikhibypgh(object di, EventArgs dj)
		{
			for (;;)
			{
				int num = 48;
				for (;;)
				{
					switch (num ^ 80)
					{
					case 88:
						this.rs.Fields["FirstName"].Value = this.txtFirstName.Text;
						num = 50;
						continue;
					case 89:
						num = 14;
						continue;
					case 90:
						num = 8;
						continue;
					case 91:
						num = 51;
						continue;
					case 92:
					{
						bool @checked;
						if (@checked)
						{
							num = 53;
							continue;
						}
						goto IL_155;
					}
					case 93:
						this.rs.Fields["LastName"].Value = this.txtLastName.Text;
						num = 11;
						continue;
					case 94:
					{
						bool @checked = this.rbMale.Checked;
						num = 12;
						continue;
					}
					case 95:
						this.rs.Fields["Title"].Value = this.cboTitle.Text;
						num = 10;
						continue;
					case 96:
						this.rs.Fields["AdminID"].Value = this.txtID.Text;
						num = 49;
						continue;
					case 97:
						num = 15;
						continue;
					case 98:
						num = 13;
						continue;
					case 99:
						this.rs.Fields["DOB"].Value = this.DateTimePicker1.Value;
						num = 9;
						continue;
					case 100:
					{
						RuntimeMethodHandle runtimeMethodHandle = methodof(Form8.get_Label4()).MethodHandle;
						num = 52;
						continue;
					}
					case 101:
						goto IL_152;
					}
					break;
				}
			}
			IL_152:
			bool flag = false;
			goto IL_158;
			IL_155:
			flag = true;
			IL_158:
			if (!flag)
			{
				this.rs.Fields["Gender"].Value = this.rbMale.Text;
				for (;;)
				{
					int num2 = 9;
					for (;;)
					{
						switch (num2 ^ 82)
						{
						case 91:
							num2 = 14;
							continue;
						case 92:
							num2 = 12;
							continue;
						case 93:
						{
							RuntimeMethodHandle runtimeMethodHandle2 = methodof(Form8.clear()).MethodHandle;
							num2 = 15;
							continue;
						}
						case 94:
							goto IL_1C2;
						}
						break;
					}
				}
				IL_1C2:;
			}
			else
			{
				bool checked2 = this.rbFemale.Checked;
				if (checked2)
				{
					this.rs.Fields["Gender"].Value = this.rbFemale.Text;
				}
			}
			this.rs.Fields["PhoneNo"].Value = this.txtPhone.Text;
			for (;;)
			{
				int num3 = Form12.wsyoqrrjsoniul(43);
				for (;;)
				{
					num3 ^= 88;
					switch (num3 + 83)
					{
					case 0:
						this.rs.Fields["Email"].Value = this.txtEmail.Text;
						num3 = -18;
						continue;
					case 1:
						num3 = -23;
						continue;
					case 2:
						num3 = -19;
						continue;
					case 3:
					{
						RuntimeMethodHandle runtimeMethodHandle3 = methodof(Form8.get_lblPassword()).MethodHandle;
						num3 = -24;
						continue;
					}
					case 4:
						this.rs.Fields["Password"].Value = this.txtPassword.Text;
						num3 = -9;
						continue;
					case 5:
						num3 = Form7.mqgfoefwabbyeu(27);
						continue;
					case 6:
						this.rs.Fields["Photo"].Value = this.str;
						num3 = -10;
						continue;
					case 7:
					{
						bool flag2;
						if (flag2)
						{
							num3 = -17;
							continue;
						}
						goto IL_359;
					}
					case 8:
					{
						bool flag2 = Operators.CompareString(this.str, "", false) == 0;
						num3 = -20;
						continue;
					}
					case 9:
						num3 = -21;
						continue;
					case 10:
						goto IL_356;
					}
					break;
				}
			}
			IL_356:
			bool flag3 = false;
			goto IL_35C;
			IL_359:
			flag3 = true;
			IL_35C:
			if (!flag3)
			{
				Interaction.MsgBox("Please Upload a Photo for the Admin.", MsgBoxStyle.Critical, null);
			}
			else
			{
				for (;;)
				{
					int num4 = 12;
					for (;;)
					{
						switch (num4 ^ 90)
						{
						case 83:
							this.rs.Update(RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value));
							num4 = 15;
							continue;
						case 84:
						{
							RuntimeMethodHandle runtimeMethodHandle4 = methodof(Form8.get_GroupBox1()).MethodHandle;
							num4 = 14;
							continue;
						}
						case 85:
							num4 = 13;
							continue;
						case 86:
							Interaction.MsgBox("Record Saved Successfully.", MsgBoxStyle.Information, null);
							num4 = 9;
							continue;
						case 87:
							goto IL_459;
						}
						break;
					}
				}
				IL_459:;
			}
		}

		// Token: 0x0600023B RID: 571 RVA: 0x0001F2D8 File Offset: 0x0001D4D8
		private void nxfpeikhibypgi(object dk, EventArgs dl)
		{
			for (;;)
			{
				IL_A9:
				int num = 1;
				int num2 = 25;
				for (;;)
				{
					num2 ^= 79;
					for (;;)
					{
						IL_3F:
						int num3 = Form12.wsyoqrrjsoniul(40);
						int num4 = Form12.wsyoqrrjsoniul(54);
						for (;;)
						{
							num4 ^= 86;
							switch (num4 + 81)
							{
							case 0:
								goto IL_3F;
							case 1:
								switch (num3 + 88)
								{
								case 0:
									switch (num2)
									{
									case 83:
										goto IL_A9;
									case 84:
										switch (num)
										{
										case 80:
											this.display();
											num = 0;
											goto IL_0B;
										case 81:
										{
											RuntimeMethodHandle runtimeMethodHandle = methodof(Form8.nxfpeikhibypgf(object, EventArgs)).MethodHandle;
											num = 3;
											goto IL_0B;
										}
										case 82:
											num = 7;
											goto IL_0B;
										case 83:
											this.rs.MoveFirst();
											num = 6;
											goto IL_0B;
										case 84:
											num = 2;
											goto IL_0B;
										case 85:
											return;
										}
										goto Block_2;
									case 85:
										goto IL_DC;
									case 86:
										break;
									default:
										num3 = -7;
										goto IL_1C;
									}
									IL_0B:
									num ^= 82;
									break;
								case 1:
									break;
								case 2:
								{
									RuntimeMethodHandle runtimeMethodHandle2 = methodof(Form8.get_cmdPhoto()).MethodHandle;
									num3 = -6;
									goto IL_1C;
								}
								case 3:
									goto IL_A4;
								default:
									num4 = -7;
									continue;
								}
								num2 = 27;
								num3 = -5;
								goto IL_1C;
							case 2:
							{
								RuntimeMethodHandle runtimeMethodHandle3 = methodof(Form8.set_txtFirstName(TextBox)).MethodHandle;
								num4 = -25;
								continue;
							}
							case 3:
								goto IL_1C;
							}
							IL_35:
							num4 = Form12.wsyoqrrjsoniul(49);
							continue;
							IL_1C:
							num3 ^= 80;
							goto IL_35;
						}
					}
					IL_A4:
					continue;
					Block_2:
					num2 = 28;
					continue;
					IL_DC:
					RuntimeMethodHandle runtimeMethodHandle4 = methodof(Form8.get_cmdNext()).MethodHandle;
					num2 = 26;
				}
			}
		}

		// Token: 0x0600023C RID: 572 RVA: 0x0001F458 File Offset: 0x0001D658
		private void nxfpeikhibypgj(object dm, EventArgs dn)
		{
			for (;;)
			{
				IL_D1:
				int num = 6;
				int num2 = 12;
				for (;;)
				{
					num2 ^= 87;
					for (;;)
					{
						IL_59:
						int num3 = 3;
						int num4 = Form12.wsyoqrrjsoniul(48);
						for (;;)
						{
							num4 ^= 84;
							switch (num4 + 79)
							{
							case 0:
								switch (num3)
								{
								case 82:
									break;
								case 83:
								{
									RuntimeMethodHandle runtimeMethodHandle = methodof(Form8.get_txtLastName()).MethodHandle;
									num3 = 4;
									goto IL_19;
								}
								case 84:
									switch (num2)
									{
									case 88:
										goto IL_9A;
									case 89:
										switch (num)
										{
										case 86:
										{
											RuntimeMethodHandle runtimeMethodHandle2 = methodof(Form8.get_txtID()).MethodHandle;
											num = 7;
											goto IL_0B;
										}
										case 87:
											this.rs.MoveLast();
											num = 11;
											goto IL_0B;
										case 88:
											num = 10;
											goto IL_0B;
										case 89:
											this.display();
											num = 9;
											goto IL_0B;
										case 90:
											num = 8;
											goto IL_0B;
										case 91:
											return;
										}
										goto Block_2;
									case 90:
										goto IL_D1;
									case 91:
										break;
									default:
										num3 = 5;
										goto IL_19;
									}
									IL_0B:
									num ^= 81;
									break;
								case 85:
									goto IL_95;
								default:
									num4 = -25;
									continue;
								}
								num2 = 14;
								num3 = 2;
								goto IL_19;
							case 1:
							{
								RuntimeMethodHandle runtimeMethodHandle3 = methodof(Form8.set_Label4(Label)).MethodHandle;
								num4 = -26;
								continue;
							}
							case 2:
								goto IL_59;
							case 3:
								goto IL_19;
							}
							IL_32:
							num4 = Form12.wsyoqrrjsoniul(56);
							continue;
							IL_19:
							num3 ^= 87;
							goto IL_32;
						}
					}
					IL_95:
					continue;
					IL_9A:
					RuntimeMethodHandle runtimeMethodHandle4 = methodof(Form8.get_GroupBox2()).MethodHandle;
					num2 = 15;
					continue;
					Block_2:
					num2 = 13;
				}
			}
		}

		// Token: 0x0600023D RID: 573 RVA: 0x0001F5CC File Offset: 0x0001D7CC
		private void nxfpeikhibypgk(object dp, EventArgs dq)
		{
			for (;;)
			{
				IL_63:
				int num = Form12.wsyoqrrjsoniul(41);
				int num2 = 3;
				for (;;)
				{
					num2 ^= 84;
					for (;;)
					{
						int num3 = Form12.wsyoqrrjsoniul(51);
						for (;;)
						{
							num3 ^= 87;
							switch (num3 + 83)
							{
							case 0:
								goto IL_35;
							case 1:
								switch (num2)
								{
								case 84:
									goto IL_63;
								case 85:
									switch (num + 79)
									{
									case 0:
									{
										bool flag;
										if (flag)
										{
											num = -20;
											goto IL_08;
										}
										goto IL_FD;
									}
									case 1:
										this.rs.MoveNext();
										num = -23;
										goto IL_08;
									case 2:
										num = -17;
										goto IL_08;
									case 3:
									{
										RuntimeMethodHandle runtimeMethodHandle = methodof(Form8.get_GroupBox2()).MethodHandle;
										num = Form8.nxfpeikhibypgs(81);
										goto IL_08;
									}
									case 4:
									{
										bool flag = !this.rs.EOF;
										num = -21;
										goto IL_08;
									}
									case 5:
										goto IL_FA;
									}
									goto Block_1;
								case 86:
									goto IL_97;
								case 87:
									break;
								default:
									num3 = Form2.uwpnsrqhswlmjh(44);
									continue;
								}
								IL_08:
								num ^= 90;
								goto IL_35;
							case 2:
							{
								RuntimeMethodHandle runtimeMethodHandle2 = methodof(Form8.get_txtFirstName()).MethodHandle;
								num3 = -8;
								continue;
							}
							case 3:
								goto IL_61;
							}
							break;
							IL_35:
							num2 = 1;
							num3 = -25;
						}
					}
					IL_61:
					continue;
					Block_1:
					num2 = 0;
					continue;
					IL_97:
					RuntimeMethodHandle runtimeMethodHandle3 = methodof(Form8.set_cmdSearch(Button)).MethodHandle;
					num2 = 2;
				}
			}
			IL_FA:
			bool flag2 = false;
			goto IL_100;
			IL_FD:
			flag2 = true;
			IL_100:
			if (!flag2)
			{
				this.display();
			}
			else
			{
				for (;;)
				{
					int num4 = Form7.mqgfoefwabbyeu(21);
					for (;;)
					{
						num4 ^= 91;
						switch (num4 + 89)
						{
						case 0:
							this.display();
							num4 = -16;
							continue;
						case 1:
							this.rs.MoveFirst();
							num4 = -15;
							continue;
						case 2:
						{
							RuntimeMethodHandle runtimeMethodHandle4 = methodof(Form8.nxfpeikhibypgg(object, EventArgs)).MethodHandle;
							num4 = -14;
							continue;
						}
						case 3:
							num4 = -4;
							continue;
						case 4:
							num4 = Form7.mqgfoefwabbyeu(32);
							continue;
						case 5:
							goto IL_1CE;
						}
						break;
					}
				}
				IL_1CE:;
			}
		}

		// Token: 0x0600023E RID: 574 RVA: 0x0001F7A8 File Offset: 0x0001D9A8
		private void nxfpeikhibypgl(object dr, EventArgs ds)
		{
			for (;;)
			{
				IL_8A:
				int num = 6;
				int num2 = 3;
				for (;;)
				{
					num2 ^= 91;
					for (;;)
					{
						int num3 = 7;
						for (;;)
						{
							switch (num3 ^ 92)
							{
							case 91:
								switch (num2)
								{
								case 85:
									goto IL_59;
								case 86:
									switch (num)
									{
									case 90:
										num = 7;
										goto IL_0B;
									case 91:
									{
										bool bof;
										if (bof)
										{
											num = 5;
											goto IL_0B;
										}
										goto IL_DF;
									}
									case 92:
										this.rs.MovePrevious();
										num = 0;
										goto IL_0B;
									case 93:
									{
										bool bof = this.rs.BOF;
										num = 1;
										goto IL_0B;
									}
									case 94:
									{
										RuntimeMethodHandle runtimeMethodHandle = methodof(Form8.set_Label1(Label)).MethodHandle;
										num = 4;
										goto IL_0B;
									}
									case 95:
										goto IL_DC;
									}
									goto Block_1;
								case 87:
									goto IL_8A;
								case 88:
									break;
								default:
									num3 = 1;
									continue;
								}
								IL_0B:
								num ^= 90;
								goto IL_4F;
							case 92:
							{
								RuntimeMethodHandle runtimeMethodHandle2 = methodof(Form8.get_Label1()).MethodHandle;
								num3 = 0;
								continue;
							}
							case 93:
								goto IL_4F;
							case 94:
								goto IL_57;
							}
							break;
							IL_4F:
							num2 = 13;
							num3 = 2;
						}
					}
					IL_57:
					continue;
					IL_59:
					RuntimeMethodHandle runtimeMethodHandle3 = methodof(Form8.nxfpeikhibypgp(object, EventArgs)).MethodHandle;
					num2 = 14;
					continue;
					Block_1:
					num2 = 12;
				}
			}
			IL_DC:
			bool flag = false;
			goto IL_E2;
			IL_DF:
			flag = true;
			IL_E2:
			if (!flag)
			{
				this.rs.MoveLast();
				for (;;)
				{
					int num4 = 13;
					for (;;)
					{
						switch (num4 ^ 84)
						{
						case 88:
						{
							RuntimeMethodHandle runtimeMethodHandle4 = methodof(Form8.get_rbMale()).MethodHandle;
							num4 = 12;
							continue;
						}
						case 89:
							num4 = 14;
							continue;
						case 90:
							this.display();
							num4 = 15;
							continue;
						case 91:
							num4 = 8;
							continue;
						case 92:
							num4 = 9;
							continue;
						case 93:
							goto IL_16A;
						}
						break;
					}
				}
				IL_16A:;
			}
			else
			{
				this.display();
			}
		}

		// Token: 0x0600023F RID: 575 RVA: 0x0001F950 File Offset: 0x0001DB50
		private void nxfpeikhibypgm(object dt, EventArgs du)
		{
			for (;;)
			{
				IL_A6:
				int num = 7;
				int num2 = 10;
				for (;;)
				{
					num2 ^= 80;
					for (;;)
					{
						int num3 = 15;
						for (;;)
						{
							switch (num3 ^ 83)
							{
							case 90:
							{
								RuntimeMethodHandle runtimeMethodHandle = methodof(Form8.set_cmdPhoto(Button)).MethodHandle;
								num3 = 9;
								continue;
							}
							case 91:
								goto IL_45;
							case 92:
								switch (num2)
								{
								case 87:
									switch (num)
									{
									case 80:
									{
										bool flag;
										if (flag)
										{
											num = 2;
											goto IL_0B;
										}
										goto IL_107;
									}
									case 81:
									{
										string value = Conversions.ToString((int)Interaction.MsgBox("Do You Really Want to Delete This Admin Profile?", MsgBoxStyle.YesNo | MsgBoxStyle.Critical, "Deletion Confirmation"));
										num = 5;
										goto IL_0B;
									}
									case 82:
									{
										RuntimeMethodHandle runtimeMethodHandle2 = methodof(Form8.set_rbMale(RadioButton)).MethodHandle;
										num = 4;
										goto IL_0B;
									}
									case 83:
									{
										string value;
										bool flag = Conversions.ToDouble(value) == 6.0;
										num = 6;
										goto IL_0B;
									}
									case 84:
										goto IL_104;
									}
									goto Block_2;
								case 88:
									goto IL_98;
								case 89:
									goto IL_A6;
								case 90:
									break;
								default:
									num3 = 8;
									continue;
								}
								IL_0B:
								num ^= 86;
								goto IL_45;
							case 93:
								goto IL_70;
							}
							break;
							IL_45:
							num2 = 7;
							num3 = 14;
						}
					}
					IL_70:
					continue;
					Block_2:
					num2 = 9;
					continue;
					IL_98:
					RuntimeMethodHandle runtimeMethodHandle3 = methodof(Form8.get_cmdBack()).MethodHandle;
					num2 = 8;
				}
			}
			IL_104:
			bool flag2 = false;
			goto IL_10A;
			IL_107:
			flag2 = true;
			IL_10A:
			if (!flag2)
			{
				this.rs.Delete(AffectEnum.adAffectCurrent);
				for (;;)
				{
					int num4 = Form7.mqgfoefwabbyeu(27);
					for (;;)
					{
						num4 ^= 82;
						switch (num4 + 92)
						{
						case 0:
							Interaction.MsgBox("Record Deleted Successfully.", MsgBoxStyle.Information, "Message");
							num4 = Form2.uwpnsrqhswlmjh(44);
							continue;
						case 1:
							num4 = -2;
							continue;
						case 2:
						{
							RuntimeMethodHandle runtimeMethodHandle4 = methodof(Form8.set_cmdDisplay(Button)).MethodHandle;
							num4 = -12;
							continue;
						}
						case 3:
							num4 = -10;
							continue;
						case 4:
							this.rs.Update(RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value));
							num4 = -8;
							continue;
						case 5:
							num4 = -9;
							continue;
						case 6:
							num4 = -7;
							continue;
						case 7:
							this.refreshData();
							num4 = -5;
							continue;
						case 8:
							goto IL_200;
						}
						break;
					}
				}
				IL_200:;
			}
			else
			{
				Interaction.MsgBox("Record Not Deleted.", MsgBoxStyle.Information, "Message");
			}
		}

		// Token: 0x06000240 RID: 576 RVA: 0x0001FB7C File Offset: 0x0001DD7C
		private void nxfpeikhibypgn(object dv, EventArgs dw)
		{
			for (;;)
			{
				IL_4D:
				int num = 9;
				int num2 = Form12.wsyoqrrjsoniul(52);
				for (;;)
				{
					num2 ^= 83;
					switch (num2 + 83)
					{
					case 0:
					{
						RuntimeMethodHandle runtimeMethodHandle = methodof(Form8.set_GroupBox2(GroupBox)).MethodHandle;
						num2 = -2;
						continue;
					}
					case 1:
						switch (num)
						{
						case 86:
						{
							bool @checked = this.rbMale.Checked;
							num = 4;
							goto IL_08;
						}
						case 87:
						{
							bool @checked;
							if (@checked)
							{
								num = 48;
								goto IL_08;
							}
							goto IL_194;
						}
						case 88:
							num = 5;
							goto IL_08;
						case 89:
							num = 12;
							goto IL_08;
						case 90:
							this.rs.Fields["AdminID"].Value = this.txtID.Text;
							num = 50;
							goto IL_08;
						case 91:
							this.rs.Fields["Title"].Value = this.cboTitle.Text;
							num = 14;
							goto IL_08;
						case 92:
							this.rs.Fields["LastName"].Value = this.txtLastName.Text;
							num = 10;
							goto IL_08;
						case 93:
							num = 49;
							goto IL_08;
						case 94:
						{
							RuntimeMethodHandle runtimeMethodHandle2 = methodof(Form8.set_GroupBox1(GroupBox)).MethodHandle;
							num = 13;
							goto IL_08;
						}
						case 95:
							this.rs.Fields["DOB"].Value = this.DateTimePicker1.Value;
							num = 11;
							goto IL_08;
						case 96:
							num = 15;
							goto IL_08;
						case 97:
							num = 8;
							goto IL_08;
						case 98:
							this.rs.Fields["FirstName"].Value = this.txtFirstName.Text;
							num = 51;
							goto IL_08;
						case 99:
							goto IL_191;
						default:
							num2 = -4;
							continue;
						}
						break;
					case 2:
						goto IL_4D;
					case 3:
						goto IL_08;
					}
					IL_23:
					num2 = Form7.mqgfoefwabbyeu(31);
					continue;
					IL_08:
					num ^= 83;
					goto IL_23;
				}
			}
			IL_191:
			bool flag = false;
			goto IL_197;
			IL_194:
			flag = true;
			IL_197:
			if (!flag)
			{
				this.rs.Fields["Gender"].Value = this.rbMale.Text;
				for (;;)
				{
					int num3 = Form6.sbdifomqugmuko(57);
					for (;;)
					{
						num3 ^= 88;
						switch (num3 + 79)
						{
						case 0:
						{
							RuntimeMethodHandle runtimeMethodHandle3 = methodof(Form8.get_GroupBox1()).MethodHandle;
							num3 = -23;
							continue;
						}
						case 1:
							num3 = -20;
							continue;
						case 2:
							num3 = Form12.wsyoqrrjsoniul(43);
							continue;
						case 3:
							goto IL_20E;
						}
						break;
					}
				}
				IL_20E:;
			}
			else
			{
				bool checked2 = this.rbFemale.Checked;
				if (checked2)
				{
					this.rs.Fields["Gender"].Value = this.rbFemale.Text;
				}
			}
			this.rs.Fields["PhoneNo"].Value = this.txtPhone.Text;
			for (;;)
			{
				int num4 = 0;
				for (;;)
				{
					switch (num4 ^ 90)
					{
					case 84:
						num4 = 7;
						continue;
					case 85:
						this.rs.Fields["Email"].Value = this.txtEmail.Text;
						num4 = 2;
						continue;
					case 86:
						num4 = 3;
						continue;
					case 87:
						this.rs.Update(RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value));
						num4 = 1;
						continue;
					case 88:
						num4 = 6;
						continue;
					case 89:
						this.rs.Fields["Password"].Value = this.txtPassword.Text;
						num4 = 14;
						continue;
					case 90:
						num4 = 15;
						continue;
					case 91:
						num4 = 5;
						continue;
					case 92:
						this.rs.Fields["Photo"].Value = this.str;
						num4 = 12;
						continue;
					case 93:
						Interaction.MsgBox("Record Updated Successfully.", MsgBoxStyle.Information, null);
						num4 = 13;
						continue;
					case 94:
					{
						RuntimeMethodHandle runtimeMethodHandle4 = methodof(Form8.get_Label8()).MethodHandle;
						num4 = 4;
						continue;
					}
					case 95:
						return;
					}
					break;
				}
			}
		}

		// Token: 0x06000241 RID: 577 RVA: 0x0001FF9B File Offset: 0x0001E19B
		private void nxfpeikhibypgo(object dx, EventArgs dy)
		{
			this.display();
		}

		// Token: 0x06000242 RID: 578 RVA: 0x0001FFAC File Offset: 0x0001E1AC
		private void nxfpeikhibypgp(object dz, EventArgs ea)
		{
			for (;;)
			{
				IL_D0:
				int num = Form7.mqgfoefwabbyeu(24);
				int num2 = 9;
				for (;;)
				{
					num2 ^= 90;
					for (;;)
					{
						IL_59:
						int num3 = 7;
						int num4 = 4;
						for (;;)
						{
							switch (num4 ^ 81)
							{
							case 82:
								switch (num3)
								{
								case 92:
									switch (num2)
									{
									case 80:
										switch (num + 89)
										{
										case 0:
										{
											RuntimeMethodHandle runtimeMethodHandle = methodof(Form8.set_GroupBox2(GroupBox)).MethodHandle;
											num = -11;
											goto IL_0B;
										}
										case 1:
											num = Form7.mqgfoefwabbyeu(25);
											goto IL_0B;
										case 2:
											num = -7;
											goto IL_0B;
										case 3:
										{
											bool flag;
											if (flag)
											{
												num = -4;
												goto IL_0B;
											}
											goto IL_178;
										}
										case 4:
										{
											bool flag = !this.rs.EOF;
											num = -8;
											goto IL_0B;
										}
										case 5:
											this.rs.Close();
											num = -6;
											goto IL_0B;
										case 6:
											this.rs.Open("Select * from AdminsProfile where AdminID = '" + this.txtID.Text + "'", this.con, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
											num = -5;
											goto IL_0B;
										case 7:
											goto IL_175;
										}
										goto Block_2;
									case 81:
										goto IL_C2;
									case 82:
										goto IL_D0;
									case 83:
										break;
									default:
										num3 = 5;
										goto IL_1C;
									}
									IL_0B:
									num ^= 82;
									break;
								case 93:
								{
									RuntimeMethodHandle runtimeMethodHandle2 = methodof(Form8.get_Label1()).MethodHandle;
									num3 = 6;
									goto IL_1C;
								}
								case 94:
									break;
								case 95:
									goto IL_90;
								default:
									num4 = 5;
									continue;
								}
								num2 = 10;
								num3 = 4;
								goto IL_1C;
							case 83:
							{
								RuntimeMethodHandle runtimeMethodHandle3 = methodof(Form8.set_Label4(Label)).MethodHandle;
								num4 = 2;
								continue;
							}
							case 84:
								goto IL_59;
							case 85:
								goto IL_1C;
							}
							IL_37:
							num4 = 3;
							continue;
							IL_1C:
							num3 ^= 91;
							goto IL_37;
						}
					}
					IL_90:
					continue;
					Block_2:
					num2 = 8;
					continue;
					IL_C2:
					RuntimeMethodHandle runtimeMethodHandle4 = methodof(Form8.set_txtPassword(TextBox)).MethodHandle;
					num2 = 11;
				}
			}
			IL_175:
			bool flag2 = false;
			goto IL_17B;
			IL_178:
			flag2 = true;
			IL_17B:
			if (!flag2)
			{
				this.display();
				this.reload();
			}
			else
			{
				Interaction.MsgBox("Record Not Found.", MsgBoxStyle.Information, null);
			}
		}

		// Token: 0x06000243 RID: 579 RVA: 0x000201A0 File Offset: 0x0001E3A0
		private void nxfpeikhibypgq(object eb, EventArgs ec)
		{
			for (;;)
			{
				IL_A6:
				int num = 15;
				int num2 = Form2.uwpnsrqhswlmjh(34);
				for (;;)
				{
					num2 ^= 92;
					for (;;)
					{
						IL_45:
						int num3 = 29;
						int num4 = 8;
						for (;;)
						{
							switch (num4 ^ 90)
							{
							case 79:
								switch (num3)
								{
								case 81:
									break;
								case 82:
									switch (num2 + 92)
									{
									case 0:
										goto IL_98;
									case 1:
										goto IL_A6;
									case 2:
										switch (num)
										{
										case 87:
											num = 8;
											goto IL_0B;
										case 88:
											yupufqwjlhlkfh.whvgmsxtmdbkxx.hcphoarosyelxe.Show();
											num = 3;
											goto IL_0B;
										case 89:
											num = 12;
											goto IL_0B;
										case 90:
										{
											RuntimeMethodHandle runtimeMethodHandle = methodof(Form8.set_cmdLast(Button)).MethodHandle;
											num = 14;
											goto IL_0B;
										}
										case 91:
											base.Hide();
											num = 13;
											goto IL_0B;
										case 92:
											return;
										}
										goto Block_2;
									case 3:
										break;
									default:
										num3 = 30;
										goto IL_19;
									}
									IL_0B:
									num ^= 84;
									break;
								case 83:
								{
									RuntimeMethodHandle runtimeMethodHandle2 = methodof(Form8.get_Label2()).MethodHandle;
									num3 = 28;
									goto IL_19;
								}
								case 84:
									goto IL_93;
								default:
									num4 = 10;
									continue;
								}
								num2 = Form2.uwpnsrqhswlmjh(44);
								num3 = 27;
								goto IL_19;
							case 80:
								goto IL_45;
							case 81:
							{
								RuntimeMethodHandle runtimeMethodHandle3 = methodof(Form8.get_cmdLast()).MethodHandle;
								num4 = 11;
								continue;
							}
							case 82:
								goto IL_19;
							}
							IL_32:
							num4 = 21;
							continue;
							IL_19:
							num3 ^= 79;
							goto IL_32;
						}
					}
					IL_93:
					continue;
					IL_98:
					RuntimeMethodHandle runtimeMethodHandle4 = methodof(Form8.nxfpeikhibypgh(object, EventArgs)).MethodHandle;
					num2 = -8;
					continue;
					Block_2:
					num2 = -7;
				}
			}
		}

		// Token: 0x06000244 RID: 580 RVA: 0x0002031C File Offset: 0x0001E51C
		private void nxfpeikhibypgr(object ed, EventArgs ee)
		{
			for (;;)
			{
				IL_A0:
				int num = 12;
				int num2 = 11;
				for (;;)
				{
					num2 ^= 83;
					for (;;)
					{
						IL_59:
						int num3 = 13;
						int num4 = Form6.sbdifomqugmuko(61);
						for (;;)
						{
							num4 ^= 80;
							switch (num4 + 81)
							{
							case 0:
								switch (num3)
								{
								case 91:
								{
									RuntimeMethodHandle runtimeMethodHandle = methodof(Form8.reload()).MethodHandle;
									num3 = 11;
									goto IL_19;
								}
								case 92:
									break;
								case 93:
									switch (num2)
									{
									case 85:
										goto IL_A0;
									case 86:
										switch (num)
										{
										case 86:
											this.lblPassword.Visible = true;
											num = 0;
											goto IL_0B;
										case 87:
										{
											RuntimeMethodHandle runtimeMethodHandle2 = methodof(Form8.set_cmdLast(Button)).MethodHandle;
											num = 13;
											goto IL_0B;
										}
										case 88:
											this.txtPassword.Visible = true;
											num = 3;
											goto IL_0B;
										case 89:
											num = 1;
											goto IL_0B;
										case 90:
											num = 2;
											goto IL_0B;
										case 91:
											return;
										}
										goto Block_2;
									case 87:
										goto IL_D3;
									case 88:
										break;
									default:
										num3 = 12;
										goto IL_19;
									}
									IL_0B:
									num ^= 90;
									break;
								case 94:
									goto IL_9B;
								default:
									num4 = -31;
									continue;
								}
								num2 = 5;
								num3 = 14;
								goto IL_19;
							case 1:
							{
								RuntimeMethodHandle runtimeMethodHandle3 = methodof(Form8.nxfpeikhibypge(object, EventArgs)).MethodHandle;
								num4 = -32;
								continue;
							}
							case 2:
								goto IL_59;
							case 3:
								goto IL_19;
							}
							IL_32:
							num4 = Form7.mqgfoefwabbyeu(25);
							continue;
							IL_19:
							num3 ^= 80;
							goto IL_32;
						}
					}
					IL_9B:
					continue;
					Block_2:
					num2 = 6;
					continue;
					IL_D3:
					RuntimeMethodHandle runtimeMethodHandle4 = methodof(Form8.reload()).MethodHandle;
					num2 = 4;
				}
			}
		}

		// Token: 0x06000245 RID: 581 RVA: 0x0002049C File Offset: 0x0001E69C
		internal static int nxfpeikhibypgs(int ef)
		{
			if (ef != -143388380 - 431181025 + 574569480)
			{
				switch (ef - -(~(370141016 ^ 370142951) >> 5))
				{
				case 0:
					return -671590159 + 99402602 - -572187446;
				case 1:
				case 2:
					break;
				case 3:
					return ~(-(~(-444300127 - -444300143)));
				case 4:
					return ~7167 >> 6;
				default:
					if (ef == ~(-(-392346500 ^ -392346588)))
					{
						return ~(238920095 + -238919983);
					}
					break;
				}
				return -((622303408 ^ -229569772) + 683240541);
			}
			return -(48991011 ^ 48992227) >> 6;
		}

		// Token: 0x040000DE RID: 222
		private IContainer components;

		// Token: 0x04000106 RID: 262
		private Connection con;

		// Token: 0x04000107 RID: 263
		private Recordset rs;

		// Token: 0x04000108 RID: 264
		private string str;
	}
}
