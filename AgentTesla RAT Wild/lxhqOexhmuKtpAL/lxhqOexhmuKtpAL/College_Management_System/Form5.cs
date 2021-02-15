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
	// Token: 0x02000015 RID: 21
	[DesignerGenerated]
	public class Form5 : Form
	{
		// Token: 0x06000175 RID: 373 RVA: 0x00015B50 File Offset: 0x00013D50
		public Form5()
		{
			for (;;)
			{
				IL_AC:
				int num = Form2.uwpnsrqhswlmjh(42);
				int num2 = 30;
				for (;;)
				{
					num2 ^= 81;
					for (;;)
					{
						IL_40:
						int num3 = 3;
						int num4 = 22;
						for (;;)
						{
							switch (num4 ^ 69)
							{
							case 80:
								goto IL_40;
							case 81:
							{
								RuntimeMethodHandle runtimeMethodHandle = methodof(Form5.set_Label1(Label)).MethodHandle;
								num4 = 20;
								continue;
							}
							case 82:
								switch (num3)
								{
								case 73:
									switch (num2)
									{
									case 76:
										goto IL_AC;
									case 77:
										switch (num + 78)
										{
										case 0:
										{
											RuntimeMethodHandle runtimeMethodHandle2 = methodof(Form5.set_Label2(Label)).MethodHandle;
											num = -7;
											goto IL_11;
										}
										case 1:
											num = -2;
											goto IL_11;
										case 2:
											this.vsvsbbpqacuxsm();
											num = -3;
											goto IL_11;
										case 3:
											this.con = (Connection)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("00000514-0000-0010-8000-00AA006D2EA4")));
											num = -13;
											goto IL_11;
										case 4:
											num = -14;
											goto IL_11;
										case 5:
											base.Load += this.vsvsbbpqacuxsn;
											num = -8;
											goto IL_11;
										case 6:
											this.rs = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("00000535-0000-0010-8000-00AA006D2EA4")));
											num = -1;
											goto IL_11;
										case 7:
											return;
										}
										goto Block_3;
									case 78:
										goto IL_ED;
									case 79:
										break;
									default:
										num3 = 1;
										goto IL_22;
									}
									IL_11:
									num ^= 75;
									break;
								case 74:
								{
									RuntimeMethodHandle runtimeMethodHandle3 = methodof(Form5.set_OpenFileDialog1(OpenFileDialog)).MethodHandle;
									num3 = 0;
									goto IL_22;
								}
								case 75:
									break;
								case 76:
									goto IL_A7;
								default:
									num4 = 21;
									continue;
								}
								num2 = 28;
								num3 = 6;
								goto IL_22;
							case 83:
								goto IL_22;
							}
							IL_3B:
							num4 = 23;
							continue;
							IL_22:
							num3 ^= 74;
							goto IL_3B;
						}
					}
					IL_A7:
					continue;
					Block_3:
					num2 = 29;
					continue;
					IL_ED:
					RuntimeMethodHandle runtimeMethodHandle4 = methodof(Form5.get_Label8()).MethodHandle;
					num2 = 31;
				}
			}
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00015D2C File Offset: 0x00013F2C
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
						IL_11E:
						int num = 0;
						int num2 = 7;
						for (;;)
						{
							num2 ^= 72;
							for (;;)
							{
								IL_85:
								int num3 = 27;
								int num4 = -10;
								for (;;)
								{
									num4 ^= 71;
									switch (num4 + 82)
									{
									case 0:
										goto IL_85;
									case 1:
									{
										RuntimeMethodHandle runtimeMethodHandle = methodof(Form5.get_lblPassword()).MethodHandle;
										num4 = Form12.wsyoqrrjsoniul(41);
										continue;
									}
									case 2:
										switch (num3)
										{
										case 80:
											switch (num2)
											{
											case 76:
												switch (num)
												{
												case 76:
													num = 2;
													goto IL_3E;
												case 77:
													this.components.Dispose();
													num = 1;
													goto IL_3E;
												case 78:
												{
													RuntimeMethodHandle runtimeMethodHandle2 = methodof(Form5.set_txtFirstName(TextBox)).MethodHandle;
													num = 3;
													goto IL_3E;
												}
												case 79:
													goto IL_189;
												}
												goto Block_6;
											case 77:
												goto IL_11E;
											case 78:
												goto IL_130;
											case 79:
												break;
											default:
												num3 = 25;
												goto IL_4F;
											}
											IL_3E:
											num ^= 77;
											break;
										case 81:
										{
											RuntimeMethodHandle runtimeMethodHandle3 = methodof(Form5.set_Label6(Label)).MethodHandle;
											num3 = 26;
											goto IL_4F;
										}
										case 82:
											break;
										case 83:
											goto IL_F9;
										default:
											num4 = -23;
											continue;
										}
										num2 = 4;
										num3 = 24;
										break;
									case 3:
										break;
									default:
										IL_7A:
										num4 = Form7.mqgfoefwabbyeu(32);
										continue;
									}
									IL_4F:
									num3 ^= 75;
									goto IL_7A;
								}
							}
							IL_F9:
							continue;
							Block_6:
							num2 = 5;
							continue;
							IL_130:
							RuntimeMethodHandle runtimeMethodHandle4 = methodof(Form5.set_txtFirstName(TextBox)).MethodHandle;
							num2 = 6;
						}
					}
					IL_189:;
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00015EF0 File Offset: 0x000140F0
		[DebuggerStepThrough]
		private void vsvsbbpqacuxsm()
		{
			for (;;)
			{
				int num = Form10.pdqangwdsoatqb(79);
				for (;;)
				{
					num ^= 72;
					switch (num + 76)
					{
					case 0:
						this.txtPassword.TabIndex = 149;
						this.lblPassword.AutoSize = true;
						this.lblPassword.ForeColor = Color.White;
						this.lblPassword.Location = new Point(76, 428);
						this.lblPassword.Name = "lblPassword";
						this.lblPassword.Size = new Size(73, 17);
						this.lblPassword.TabIndex = 148;
						this.lblPassword.Text = "Password:";
						this.cmdSchedule.BackColor = Color.BlueViolet;
						this.cmdSchedule.ForeColor = Color.White;
						this.cmdSchedule.Location = new Point(570, 470);
						num = -128;
						continue;
					case 1:
					{
						RuntimeMethodHandle runtimeMethodHandle = methodof(Form5.set_txtPhone(TextBox)).MethodHandle;
						num = -3;
						continue;
					}
					case 2:
						this.Label4.AutoSize = true;
						this.Label4.ForeColor = Color.White;
						this.Label4.Location = new Point(76, 225);
						this.Label4.Name = "Label4";
						this.Label4.Size = new Size(80, 17);
						this.Label4.TabIndex = 140;
						this.Label4.Text = "Last Name:";
						this.Label3.AutoSize = true;
						this.Label3.ForeColor = Color.White;
						this.Label3.Location = new Point(76, 188);
						this.Label3.Name = "Label3";
						num = -11;
						continue;
					case 3:
						this.rbFemale.Location = new Point(413, 289);
						this.rbFemale.Name = "rbFemale";
						this.rbFemale.Size = new Size(72, 21);
						this.rbFemale.TabIndex = 134;
						this.rbFemale.TabStop = true;
						this.rbFemale.Text = "Female";
						this.rbFemale.UseVisualStyleBackColor = true;
						this.rbMale.AutoSize = true;
						this.rbMale.ForeColor = Color.White;
						this.rbMale.Location = new Point(175, 289);
						this.rbMale.Name = "rbMale";
						num = -16;
						continue;
					case 4:
						this.rbMale.Size = new Size(56, 21);
						this.rbMale.TabIndex = 133;
						this.rbMale.TabStop = true;
						this.rbMale.Text = "Male";
						this.rbMale.UseVisualStyleBackColor = true;
						this.PictureBox1.BackColor = Color.SteelBlue;
						this.PictureBox1.Location = new Point(514, 116);
						this.PictureBox1.Name = "PictureBox1";
						this.PictureBox1.Size = new Size(200, 150);
						this.PictureBox1.TabIndex = 132;
						this.PictureBox1.TabStop = false;
						num = -9;
						continue;
					case 5:
						this.cmdUpdate.Name = "cmdUpdate";
						this.cmdUpdate.Size = new Size(112, 34);
						this.cmdUpdate.TabIndex = 124;
						this.cmdUpdate.Text = "SAVE";
						this.cmdUpdate.UseVisualStyleBackColor = false;
						this.Label8.AutoSize = true;
						this.Label8.ForeColor = Color.White;
						this.Label8.Location = new Point(76, 354);
						this.Label8.Name = "Label8";
						this.Label8.Size = new Size(75, 17);
						this.Label8.TabIndex = 144;
						num = -113;
						continue;
					case 6:
						this.txtEmail.Name = "txtEmail";
						this.txtEmail.Size = new Size(310, 23);
						this.txtEmail.TabIndex = 129;
						this.txtPhone.Location = new Point(175, 354);
						this.txtPhone.Name = "txtPhone";
						this.txtPhone.Size = new Size(310, 23);
						this.txtPhone.TabIndex = 128;
						this.txtLastName.Location = new Point(175, 225);
						this.txtLastName.Name = "txtLastName";
						this.txtLastName.Size = new Size(310, 23);
						this.txtLastName.TabIndex = 127;
						num = -12;
						continue;
					case 7:
						this.Label10.Text = "Title:";
						this.Label9.AutoSize = true;
						this.Label9.ForeColor = Color.White;
						this.Label9.Location = new Point(76, 390);
						this.Label9.Name = "Label9";
						this.Label9.Size = new Size(46, 17);
						this.Label9.TabIndex = 145;
						this.Label9.Text = "Email:";
						this.cmdUpdate.BackColor = Color.BlueViolet;
						this.cmdUpdate.ForeColor = Color.White;
						this.cmdUpdate.Location = new Point(242, 470);
						num = -15;
						continue;
					case 8:
						this.txtFirstName.Location = new Point(175, 188);
						for (;;)
						{
							int num2 = 19;
							for (;;)
							{
								switch (num2 ^ 70)
								{
								case 76:
									this.txtID.Location = new Point(175, 116);
									num2 = 21;
									continue;
								case 77:
									this.GroupBox1.Name = "GroupBox1";
									num2 = 17;
									continue;
								case 78:
									this.txtID.TabIndex = 125;
									num2 = 29;
									continue;
								case 79:
									num2 = 11;
									continue;
								case 80:
									this.txtFirstName.Name = "txtFirstName";
									num2 = 18;
									continue;
								case 81:
									num2 = 8;
									continue;
								case 82:
									this.GroupBox1.Controls.Add(this.Label2);
									num2 = 28;
									continue;
								case 83:
									num2 = 26;
									continue;
								case 84:
									num2 = 38;
									continue;
								case 85:
									num2 = 22;
									continue;
								case 86:
									num2 = 25;
									continue;
								case 87:
									num2 = 36;
									continue;
								case 88:
									this.GroupBox1.Location = new Point(208, 16);
									num2 = 9;
									continue;
								case 89:
									num2 = 27;
									continue;
								case 90:
									num2 = 30;
									continue;
								case 91:
									num2 = 20;
									continue;
								case 92:
									this.txtID.Name = "txtID";
									num2 = 31;
									continue;
								case 93:
									this.txtID.Size = new Size(310, 23);
									num2 = 23;
									continue;
								case 94:
								{
									RuntimeMethodHandle runtimeMethodHandle2 = methodof(Form5.get_cmdUpdate()).MethodHandle;
									num2 = 24;
									continue;
								}
								case 95:
									this.txtFirstName.TabIndex = 126;
									num2 = 39;
									continue;
								case 96:
									this.txtFirstName.Size = new Size(310, 23);
									num2 = 16;
									continue;
								case 97:
									num2 = 10;
									continue;
								case 98:
									num = -117;
									num2 = 37;
									continue;
								case 99:
									goto IL_808;
								}
								break;
							}
						}
						IL_808:
						continue;
					case 9:
						this.Label3.Size = new Size(80, 17);
						this.Label3.TabIndex = 139;
						this.Label3.Text = "First Name:";
						this.Label1.AutoSize = true;
						this.Label1.ForeColor = Color.White;
						this.Label1.Location = new Point(76, 119);
						this.Label1.Name = "Label1";
						this.Label1.Size = new Size(82, 17);
						this.Label1.TabIndex = 138;
						this.Label1.Text = "Lecturer ID:";
						this.cmdReturn.BackColor = Color.BlueViolet;
						num = -118;
						continue;
					case 10:
						this.Label4 = new Label();
						this.Label3 = new Label();
						this.Label1 = new Label();
						this.cmdReturn = new Button();
						this.cboTitle = new ComboBox();
						this.lblWelcome = new Label();
						this.rbFemale = new RadioButton();
						this.rbMale = new RadioButton();
						this.PictureBox1 = new PictureBox();
						this.cboSchool = new ComboBox();
						this.DateTimePicker1 = new DateTimePicker();
						num = -115;
						continue;
					case 11:
						this.cboSchool.FormattingEnabled = true;
						for (;;)
						{
							int num3 = Form6.sbdifomqugmuko(62);
							for (;;)
							{
								num3 ^= 81;
								switch (num3 + 77)
								{
								case 0:
									num = -14;
									num3 = -101;
									continue;
								case 1:
									num3 = -28;
									continue;
								case 2:
									this.DateTimePicker1.Name = "DateTimePicker1";
									num3 = -107;
									continue;
								case 3:
									num3 = -24;
									continue;
								case 4:
									this.cboSchool.Location = new Point(175, 320);
									num3 = -25;
									continue;
								case 5:
									this.DateTimePicker1.Size = new Size(310, 23);
									num3 = -110;
									continue;
								case 6:
									this.cboSchool.Name = "cboSchool";
									num3 = -112;
									continue;
								case 7:
									num3 = -30;
									continue;
								case 8:
									num3 = -108;
									continue;
								case 9:
									num3 = -20;
									continue;
								case 10:
									this.txtEmail.Location = new Point(175, 390);
									num3 = -21;
									continue;
								case 11:
									num3 = -26;
									continue;
								case 12:
									num3 = -111;
									continue;
								case 13:
									this.DateTimePicker1.Value = new DateTime(2017, 4, 8, 0, 0, 0, 0);
									num3 = -19;
									continue;
								case 14:
									num3 = -109;
									continue;
								case 15:
									this.cboSchool.Size = new Size(310, 24);
									num3 = -106;
									continue;
								case 16:
									num3 = -103;
									continue;
								case 17:
									num3 = Form2.uwpnsrqhswlmjh(45);
									continue;
								case 18:
									this.DateTimePicker1.Location = new Point(175, 260);
									num3 = -27;
									continue;
								case 19:
								{
									RuntimeMethodHandle runtimeMethodHandle3 = methodof(Form5.get_Label2()).MethodHandle;
									num3 = -105;
									continue;
								}
								case 20:
									num3 = -104;
									continue;
								case 21:
									this.DateTimePicker1.TabIndex = 130;
									num3 = -18;
									continue;
								case 22:
									this.cboSchool.TabIndex = 131;
									num3 = -22;
									continue;
								case 23:
									goto IL_B92;
								}
								break;
							}
						}
						IL_B92:
						continue;
					case 12:
						base.Controls.Add(this.cmdUpdate);
						for (;;)
						{
							int num4 = Form7.mqgfoefwabbyeu(29);
							for (;;)
							{
								num4 ^= 72;
								switch (num4 + 71)
								{
								case 0:
									base.Controls.Add(this.Label8);
									num4 = -119;
									continue;
								case 1:
								{
									RuntimeMethodHandle runtimeMethodHandle4 = methodof(Form5.get_txtPhone()).MethodHandle;
									num4 = -14;
									continue;
								}
								case 2:
									num4 = -125;
									continue;
								case 3:
									base.Controls.Add(this.lblWelcome);
									num4 = -122;
									continue;
								case 4:
									num4 = -114;
									continue;
								case 5:
									num4 = -15;
									continue;
								case 6:
									base.Controls.Add(this.Label7);
									num4 = -120;
									continue;
								case 7:
									num4 = -127;
									continue;
								case 8:
									num4 = -9;
									continue;
								case 9:
									num4 = -115;
									continue;
								case 10:
									num4 = -126;
									continue;
								case 11:
									num4 = -124;
									continue;
								case 12:
									base.Controls.Add(this.Label5);
									num4 = -121;
									continue;
								case 13:
									base.Controls.Add(this.Label3);
									num4 = -116;
									continue;
								case 14:
									num4 = -12;
									continue;
								case 15:
									num = Form10.pdqangwdsoatqb(77);
									num4 = -104;
									continue;
								case 16:
									base.Controls.Add(this.Label6);
									num4 = -118;
									continue;
								case 17:
									base.Controls.Add(this.cboTitle);
									num4 = Form8.nxfpeikhibypgs(87);
									continue;
								case 18:
									base.Controls.Add(this.cmdReturn);
									num4 = -117;
									continue;
								case 19:
									base.Controls.Add(this.Label1);
									num4 = -13;
									continue;
								case 20:
									base.Controls.Add(this.Label4);
									num4 = -11;
									continue;
								case 21:
									num4 = -128;
									continue;
								case 22:
									num4 = -123;
									continue;
								case 23:
									goto IL_DA2;
								}
								break;
							}
						}
						IL_DA2:
						continue;
					case 13:
						this.Label6.Name = "Label6";
						this.Label6.Size = new Size(60, 17);
						this.Label6.TabIndex = 142;
						this.Label6.Text = "Gender:";
						this.Label5.AutoSize = true;
						this.Label5.ForeColor = Color.White;
						this.Label5.Location = new Point(76, 260);
						this.Label5.Name = "Label5";
						this.Label5.Size = new Size(91, 17);
						this.Label5.TabIndex = 141;
						this.Label5.Text = "Date of Birth:";
						num = -2;
						continue;
					case 14:
						this.cmdReturn.ForeColor = Color.White;
						this.cmdReturn.Location = new Point(404, 470);
						this.cmdReturn.Name = "cmdReturn";
						this.cmdReturn.Size = new Size(119, 34);
						this.cmdReturn.TabIndex = 137;
						this.cmdReturn.Text = "RETURN";
						this.cmdReturn.UseVisualStyleBackColor = false;
						this.cboTitle.FormattingEnabled = true;
						this.cboTitle.Location = new Point(175, 150);
						this.cboTitle.Name = "cboTitle";
						this.cboTitle.Size = new Size(310, 24);
						num = -127;
						continue;
					case 15:
						this.GroupBox1.Size = new Size(411, 53);
						this.GroupBox1.TabIndex = 151;
						this.GroupBox1.TabStop = false;
						this.Label2.AutoSize = true;
						this.Label2.Font = new Font("Microsoft Sans Serif", 20f, FontStyle.Regular, GraphicsUnit.Point, 0);
						this.Label2.ForeColor = Color.White;
						this.Label2.Location = new Point(22, 15);
						this.Label2.Name = "Label2";
						this.Label2.Size = new Size(368, 31);
						this.Label2.TabIndex = 122;
						this.Label2.Text = "LECTURER PROFILE PAGE";
						num = -126;
						continue;
					case 16:
						this.cmdEdit = new Button();
						this.txtPassword = new TextBox();
						this.lblPassword = new Label();
						this.cmdSchedule = new Button();
						this.Label10 = new Label();
						this.Label9 = new Label();
						this.cmdUpdate = new Button();
						this.Label8 = new Label();
						this.Label7 = new Label();
						this.Label6 = new Label();
						this.Label5 = new Label();
						num = -10;
						continue;
					case 17:
						this.txtEmail = new TextBox();
						this.txtPhone = new TextBox();
						this.txtLastName = new TextBox();
						this.txtFirstName = new TextBox();
						this.txtID = new TextBox();
						this.GroupBox1 = new GroupBox();
						this.Label2 = new Label();
						this.OpenFileDialog1 = new OpenFileDialog();
						((ISupportInitialize)this.PictureBox1).BeginInit();
						this.GroupBox1.SuspendLayout();
						base.SuspendLayout();
						num = -114;
						continue;
					case 18:
						this.cmdEdit.BackColor = Color.BlueViolet;
						this.cmdEdit.ForeColor = Color.White;
						this.cmdEdit.Location = new Point(79, 470);
						this.cmdEdit.Name = "cmdEdit";
						this.cmdEdit.Size = new Size(112, 34);
						this.cmdEdit.TabIndex = 150;
						this.cmdEdit.Text = "EDIT INFO";
						this.cmdEdit.UseVisualStyleBackColor = false;
						this.txtPassword.Location = new Point(175, 425);
						this.txtPassword.Name = "txtPassword";
						this.txtPassword.Size = new Size(310, 23);
						num = -4;
						continue;
					case 19:
						this.Label8.Text = "Phone No:";
						this.Label7.AutoSize = true;
						this.Label7.ForeColor = Color.White;
						this.Label7.Location = new Point(76, 320);
						this.Label7.Name = "Label7";
						this.Label7.Size = new Size(55, 17);
						this.Label7.TabIndex = 143;
						this.Label7.Text = "School:";
						this.Label6.AutoSize = true;
						this.Label6.ForeColor = Color.White;
						this.Label6.Location = new Point(76, 289);
						num = -119;
						continue;
					case 20:
						this.cmdSchedule.Name = "cmdSchedule";
						this.cmdSchedule.Size = new Size(133, 34);
						this.cmdSchedule.TabIndex = 147;
						this.cmdSchedule.Text = "VIEW SCHEDULE";
						this.cmdSchedule.UseVisualStyleBackColor = false;
						this.Label10.AutoSize = true;
						this.Label10.ForeColor = Color.White;
						this.Label10.Location = new Point(76, 150);
						this.Label10.Name = "Label10";
						this.Label10.Size = new Size(39, 17);
						this.Label10.TabIndex = 146;
						num = -13;
						continue;
					case 21:
						this.cboTitle.TabIndex = 136;
						this.lblWelcome.AutoSize = true;
						this.lblWelcome.Font = new Font("Microsoft Sans Serif", 16f, FontStyle.Regular, GraphicsUnit.Point, 0);
						this.lblWelcome.ForeColor = Color.White;
						this.lblWelcome.Location = new Point(223, 83);
						this.lblWelcome.Name = "lblWelcome";
						this.lblWelcome.Size = new Size(74, 26);
						this.lblWelcome.TabIndex = 135;
						this.lblWelcome.Text = "Profile";
						this.rbFemale.AutoSize = true;
						this.rbFemale.ForeColor = Color.White;
						num = -1;
						continue;
					case 22:
						this.OpenFileDialog1.FileName = "OpenFileDialog1";
						base.AutoScaleDimensions = new SizeF(8f, 16f);
						base.AutoScaleMode = AutoScaleMode.Font;
						this.BackColor = Color.SteelBlue;
						base.ClientSize = new Size(790, 521);
						base.Controls.Add(this.cmdEdit);
						base.Controls.Add(this.txtPassword);
						base.Controls.Add(this.lblPassword);
						base.Controls.Add(this.cmdSchedule);
						base.Controls.Add(this.Label10);
						base.Controls.Add(this.Label9);
						num = -120;
						continue;
					case 23:
						base.Controls.Add(this.rbFemale);
						base.Controls.Add(this.rbMale);
						base.Controls.Add(this.PictureBox1);
						base.Controls.Add(this.cboSchool);
						base.Controls.Add(this.DateTimePicker1);
						base.Controls.Add(this.txtEmail);
						base.Controls.Add(this.txtPhone);
						base.Controls.Add(this.txtLastName);
						base.Controls.Add(this.txtFirstName);
						base.Controls.Add(this.txtID);
						base.Controls.Add(this.GroupBox1);
						num = -124;
						continue;
					case 24:
						goto IL_1613;
					}
					break;
				}
			}
			IL_1613:
			this.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
			base.Margin = new Padding(4, 4, 4, 4);
			base.Name = "Form5";
			this.Text = "Form5";
			((ISupportInitialize)this.PictureBox1).EndInit();
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000178 RID: 376 RVA: 0x00017615 File Offset: 0x00015815
		// (set) Token: 0x06000179 RID: 377 RVA: 0x00017624 File Offset: 0x00015824
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
				EventHandler value2 = new EventHandler(this.vsvsbbpqacuxsr);
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

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x0600017A RID: 378 RVA: 0x0001768F File Offset: 0x0001588F
		// (set) Token: 0x0600017B RID: 379 RVA: 0x0001769D File Offset: 0x0001589D
		internal virtual TextBox txtPassword { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x0600017C RID: 380 RVA: 0x000176AA File Offset: 0x000158AA
		// (set) Token: 0x0600017D RID: 381 RVA: 0x000176B8 File Offset: 0x000158B8
		internal virtual Label lblPassword { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x0600017E RID: 382 RVA: 0x000176C5 File Offset: 0x000158C5
		// (set) Token: 0x0600017F RID: 383 RVA: 0x000176D4 File Offset: 0x000158D4
		internal virtual Button cmdSchedule
		{
			[CompilerGenerated]
			get
			{
				return this._cmdSchedule;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.vsvsbbpqacuxsq);
				Button cmdSchedule = this._cmdSchedule;
				if (cmdSchedule != null)
				{
					cmdSchedule.Click -= value2;
				}
				this._cmdSchedule = value;
				cmdSchedule = this._cmdSchedule;
				if (cmdSchedule != null)
				{
					cmdSchedule.Click += value2;
				}
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000180 RID: 384 RVA: 0x0001773F File Offset: 0x0001593F
		// (set) Token: 0x06000181 RID: 385 RVA: 0x0001774D File Offset: 0x0001594D
		internal virtual Label Label10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000182 RID: 386 RVA: 0x0001775A File Offset: 0x0001595A
		// (set) Token: 0x06000183 RID: 387 RVA: 0x00017768 File Offset: 0x00015968
		internal virtual Label Label9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000184 RID: 388 RVA: 0x00017775 File Offset: 0x00015975
		// (set) Token: 0x06000185 RID: 389 RVA: 0x00017784 File Offset: 0x00015984
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
				EventHandler value2 = new EventHandler(this.vsvsbbpqacuxso);
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

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x06000186 RID: 390 RVA: 0x000177EF File Offset: 0x000159EF
		// (set) Token: 0x06000187 RID: 391 RVA: 0x000177FD File Offset: 0x000159FD
		internal virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06000188 RID: 392 RVA: 0x0001780A File Offset: 0x00015A0A
		// (set) Token: 0x06000189 RID: 393 RVA: 0x00017818 File Offset: 0x00015A18
		internal virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x0600018A RID: 394 RVA: 0x00017825 File Offset: 0x00015A25
		// (set) Token: 0x0600018B RID: 395 RVA: 0x00017833 File Offset: 0x00015A33
		internal virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x0600018C RID: 396 RVA: 0x00017840 File Offset: 0x00015A40
		// (set) Token: 0x0600018D RID: 397 RVA: 0x0001784E File Offset: 0x00015A4E
		internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x0600018E RID: 398 RVA: 0x0001785B File Offset: 0x00015A5B
		// (set) Token: 0x0600018F RID: 399 RVA: 0x00017869 File Offset: 0x00015A69
		internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000190 RID: 400 RVA: 0x00017876 File Offset: 0x00015A76
		// (set) Token: 0x06000191 RID: 401 RVA: 0x00017884 File Offset: 0x00015A84
		internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000192 RID: 402 RVA: 0x00017891 File Offset: 0x00015A91
		// (set) Token: 0x06000193 RID: 403 RVA: 0x0001789F File Offset: 0x00015A9F
		internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x06000194 RID: 404 RVA: 0x000178AC File Offset: 0x00015AAC
		// (set) Token: 0x06000195 RID: 405 RVA: 0x000178BC File Offset: 0x00015ABC
		internal virtual Button cmdReturn
		{
			[CompilerGenerated]
			get
			{
				return this._cmdReturn;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.vsvsbbpqacuxsp);
				Button cmdReturn = this._cmdReturn;
				if (cmdReturn != null)
				{
					cmdReturn.Click -= value2;
				}
				this._cmdReturn = value;
				cmdReturn = this._cmdReturn;
				if (cmdReturn != null)
				{
					cmdReturn.Click += value2;
				}
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x06000196 RID: 406 RVA: 0x00017927 File Offset: 0x00015B27
		// (set) Token: 0x06000197 RID: 407 RVA: 0x00017935 File Offset: 0x00015B35
		internal virtual ComboBox cboTitle { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x06000198 RID: 408 RVA: 0x00017942 File Offset: 0x00015B42
		// (set) Token: 0x06000199 RID: 409 RVA: 0x00017950 File Offset: 0x00015B50
		internal virtual Label lblWelcome { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x0600019A RID: 410 RVA: 0x0001795D File Offset: 0x00015B5D
		// (set) Token: 0x0600019B RID: 411 RVA: 0x0001796B File Offset: 0x00015B6B
		internal virtual RadioButton rbFemale { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x0600019C RID: 412 RVA: 0x00017978 File Offset: 0x00015B78
		// (set) Token: 0x0600019D RID: 413 RVA: 0x00017986 File Offset: 0x00015B86
		internal virtual RadioButton rbMale { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x0600019E RID: 414 RVA: 0x00017993 File Offset: 0x00015B93
		// (set) Token: 0x0600019F RID: 415 RVA: 0x000179A1 File Offset: 0x00015BA1
		internal virtual PictureBox PictureBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x060001A0 RID: 416 RVA: 0x000179AE File Offset: 0x00015BAE
		// (set) Token: 0x060001A1 RID: 417 RVA: 0x000179BC File Offset: 0x00015BBC
		internal virtual ComboBox cboSchool { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x060001A2 RID: 418 RVA: 0x000179C9 File Offset: 0x00015BC9
		// (set) Token: 0x060001A3 RID: 419 RVA: 0x000179D7 File Offset: 0x00015BD7
		internal virtual DateTimePicker DateTimePicker1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x060001A4 RID: 420 RVA: 0x000179E4 File Offset: 0x00015BE4
		// (set) Token: 0x060001A5 RID: 421 RVA: 0x000179F2 File Offset: 0x00015BF2
		internal virtual TextBox txtEmail { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x060001A6 RID: 422 RVA: 0x000179FF File Offset: 0x00015BFF
		// (set) Token: 0x060001A7 RID: 423 RVA: 0x00017A0D File Offset: 0x00015C0D
		internal virtual TextBox txtPhone { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060001A8 RID: 424 RVA: 0x00017A1A File Offset: 0x00015C1A
		// (set) Token: 0x060001A9 RID: 425 RVA: 0x00017A28 File Offset: 0x00015C28
		internal virtual TextBox txtLastName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060001AA RID: 426 RVA: 0x00017A35 File Offset: 0x00015C35
		// (set) Token: 0x060001AB RID: 427 RVA: 0x00017A43 File Offset: 0x00015C43
		internal virtual TextBox txtFirstName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060001AC RID: 428 RVA: 0x00017A50 File Offset: 0x00015C50
		// (set) Token: 0x060001AD RID: 429 RVA: 0x00017A5E File Offset: 0x00015C5E
		internal virtual TextBox txtID { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060001AE RID: 430 RVA: 0x00017A6B File Offset: 0x00015C6B
		// (set) Token: 0x060001AF RID: 431 RVA: 0x00017A79 File Offset: 0x00015C79
		internal virtual GroupBox GroupBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060001B0 RID: 432 RVA: 0x00017A86 File Offset: 0x00015C86
		// (set) Token: 0x060001B1 RID: 433 RVA: 0x00017A94 File Offset: 0x00015C94
		internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060001B2 RID: 434 RVA: 0x00017AA1 File Offset: 0x00015CA1
		// (set) Token: 0x060001B3 RID: 435 RVA: 0x00017AAF File Offset: 0x00015CAF
		internal virtual OpenFileDialog OpenFileDialog1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x060001B4 RID: 436 RVA: 0x00017ABC File Offset: 0x00015CBC
		private void vsvsbbpqacuxsn(object ci, EventArgs cj)
		{
			for (;;)
			{
				IL_BF:
				int num = 5;
				int num2 = -1;
				for (;;)
				{
					num2 ^= 79;
					for (;;)
					{
						IL_4E:
						int num3 = Form12.wsyoqrrjsoniul(51);
						int num4 = -24;
						for (;;)
						{
							num4 ^= 91;
							switch (num4 + 80)
							{
							case 0:
								switch (num3 + 84)
								{
								case 0:
									break;
								case 1:
								{
									RuntimeMethodHandle runtimeMethodHandle = methodof(Form5.set_Label5(Label)).MethodHandle;
									num3 = Form2.uwpnsrqhswlmjh(44);
									goto IL_19;
								}
								case 2:
									switch (num2 + 83)
									{
									case 0:
										goto IL_B1;
									case 1:
										goto IL_BF;
									case 2:
										switch (num)
										{
										case 79:
											num = 7;
											goto IL_0B;
										case 80:
											num = 4;
											goto IL_0B;
										case 81:
										{
											RuntimeMethodHandle runtimeMethodHandle2 = methodof(Form5.get_cmdReturn()).MethodHandle;
											num = 1;
											goto IL_0B;
										}
										case 82:
											num = 8;
											goto IL_0B;
										case 83:
										{
											string str;
											this.lblWelcome.Text = str + "'s " + this.lblWelcome.Text;
											num = 2;
											goto IL_0B;
										}
										case 84:
											this.rs.Open("Select * from LecturersProfile where LecturerID = '" + yupufqwjlhlkfh.whvgmsxtmdbkxx.hcphoarosyelxi.txtUsername.Text + "'", this.con, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
											num = 31;
											goto IL_0B;
										case 85:
											this.con.Open("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\\Users\\Joey\\Documents\\College.mdb; Persist Security Info = False", "", "", -1);
											num = 0;
											goto IL_0B;
										case 86:
											num = 9;
											goto IL_0B;
										case 87:
										{
											string str = Conversions.ToString(this.rs.Fields["FirstName"].Value);
											num = 3;
											goto IL_0B;
										}
										case 88:
											this.display();
											num = 6;
											goto IL_0B;
										case 89:
											return;
										}
										goto Block_2;
									case 3:
										break;
									default:
										num3 = -5;
										goto IL_19;
									}
									IL_0B:
									num ^= 80;
									break;
								case 3:
									goto IL_AC;
								default:
									num4 = -22;
									continue;
								}
								num2 = Form12.wsyoqrrjsoniul(48);
								num3 = -8;
								goto IL_19;
							case 1:
								goto IL_4E;
							case 2:
							{
								RuntimeMethodHandle runtimeMethodHandle3 = methodof(Form5.get_Label4()).MethodHandle;
								num4 = -23;
								continue;
							}
							case 3:
								goto IL_19;
							}
							IL_34:
							num4 = Form6.sbdifomqugmuko(57);
							continue;
							IL_19:
							num3 ^= 87;
							goto IL_34;
						}
					}
					IL_AC:
					continue;
					IL_B1:
					RuntimeMethodHandle runtimeMethodHandle4 = methodof(Form5.vsvsbbpqacuxsp(object, EventArgs)).MethodHandle;
					num2 = -30;
					continue;
					Block_2:
					num2 = -31;
				}
			}
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x00017D08 File Offset: 0x00015F08
		public void display()
		{
			for (;;)
			{
				IL_7E:
				int num = 52;
				int num2 = -25;
				for (;;)
				{
					num2 ^= 87;
					for (;;)
					{
						int num3 = Form2.uwpnsrqhswlmjh(50);
						for (;;)
						{
							num3 ^= 86;
							switch (num3 + 81)
							{
							case 0:
							{
								RuntimeMethodHandle runtimeMethodHandle = methodof(Form5.vsvsbbpqacuxsr(object, EventArgs)).MethodHandle;
								num3 = -7;
								continue;
							}
							case 1:
								goto IL_4A;
							case 2:
								switch (num2 + 83)
								{
								case 0:
									goto IL_7E;
								case 1:
									switch (num)
									{
									case 90:
										num = 51;
										goto IL_0B;
									case 91:
										this.DateTimePicker1.Value = Conversions.ToDate(this.rs.Fields["DOB"].Value);
										num = 12;
										goto IL_0B;
									case 92:
									{
										RuntimeMethodHandle runtimeMethodHandle2 = methodof(Form5.set_DateTimePicker1(DateTimePicker)).MethodHandle;
										num = 10;
										goto IL_0B;
									}
									case 93:
										this.txtLastName.Text = Conversions.ToString(this.rs.Fields["LastName"].Value);
										num = 48;
										goto IL_0B;
									case 94:
										num = 11;
										goto IL_0B;
									case 95:
										num = 54;
										goto IL_0B;
									case 96:
										this.txtFirstName.Text = Conversions.ToString(this.rs.Fields["FirstName"].Value);
										num = 8;
										goto IL_0B;
									case 97:
										this.cboTitle.Text = Conversions.ToString(this.rs.Fields["Title"].Value);
										num = 9;
										goto IL_0B;
									case 98:
										this.txtID.Text = Conversions.ToString(this.rs.Fields["LecturerID"].Value);
										num = 53;
										goto IL_0B;
									case 99:
										num = 55;
										goto IL_0B;
									case 100:
									{
										bool flag;
										if (flag)
										{
											num = 49;
											goto IL_0B;
										}
										goto IL_260;
									}
									case 101:
									{
										bool flag = Operators.ConditionalCompareObjectEqual(this.rs.Fields["Gender"].Value, this.rbMale.Text, false);
										num = 50;
										goto IL_0B;
									}
									case 102:
										num = 13;
										goto IL_0B;
									case 103:
										goto IL_25D;
									}
									goto Block_2;
								case 2:
									goto IL_D6;
								case 3:
									break;
								default:
									num3 = -26;
									continue;
								}
								IL_0B:
								num ^= 86;
								goto IL_4A;
							case 3:
								goto IL_7C;
							}
							break;
							IL_4A:
							num2 = Form12.wsyoqrrjsoniul(51);
							num3 = -28;
						}
					}
					IL_7C:
					continue;
					Block_2:
					num2 = Form2.uwpnsrqhswlmjh(44);
					continue;
					IL_D6:
					RuntimeMethodHandle runtimeMethodHandle3 = methodof(Form5.set_txtID(TextBox)).MethodHandle;
					num2 = -8;
				}
			}
			IL_25D:
			bool flag2 = false;
			goto IL_263;
			IL_260:
			flag2 = true;
			IL_263:
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
			this.cboSchool.Text = Conversions.ToString(this.rs.Fields["School"].Value);
			for (;;)
			{
				int num4 = 24;
				for (;;)
				{
					switch (num4 ^ 79)
					{
					case 82:
						num4 = 20;
						continue;
					case 83:
					{
						RuntimeMethodHandle runtimeMethodHandle4 = methodof(Form5.set_PictureBox1(PictureBox)).MethodHandle;
						num4 = 28;
						continue;
					}
					case 84:
						num4 = 16;
						continue;
					case 85:
						this.txtPhone.Text = Conversions.ToString(this.rs.Fields["PhoneNo"].Value);
						num4 = 27;
						continue;
					case 86:
						num4 = 47;
						continue;
					case 87:
						num4 = 26;
						continue;
					case 88:
						this.PictureBox1.Image = Image.FromFile(Conversions.ToString(this.rs.Fields["Photo"].Value));
						num4 = 29;
						continue;
					case 89:
						this.txtPassword.Visible = false;
						num4 = 25;
						continue;
					case 90:
						this.lblPassword.Visible = false;
						num4 = 17;
						continue;
					case 91:
						this.txtPassword.Text = Conversions.ToString(this.rs.Fields["Password"].Value);
						num4 = 18;
						continue;
					case 92:
						num4 = 23;
						continue;
					case 93:
						num4 = 21;
						continue;
					case 94:
						num4 = 22;
						continue;
					case 95:
						this.txtEmail.Text = Conversions.ToString(this.rs.Fields["Email"].Value);
						num4 = 19;
						continue;
					case 96:
						return;
					}
					break;
				}
			}
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x000181BC File Offset: 0x000163BC
		private void vsvsbbpqacuxso(object ck, EventArgs cl)
		{
			for (;;)
			{
				IL_3D:
				int num = Form7.mqgfoefwabbyeu(24);
				int num2 = -25;
				for (;;)
				{
					num2 ^= 83;
					switch (num2 + 79)
					{
					case 0:
						switch (num + 91)
						{
						case 0:
							num = -26;
							goto IL_08;
						case 1:
							this.rs.Fields["FirstName"].Value = this.txtFirstName.Text;
							num = -6;
							goto IL_08;
						case 2:
							num = -3;
							goto IL_08;
						case 3:
							this.rs.Fields["LecturerID"].Value = this.txtID.Text;
							num = -13;
							goto IL_08;
						case 4:
						{
							bool @checked = this.rbMale.Checked;
							num = -4;
							goto IL_08;
						}
						case 5:
						{
							bool @checked;
							if (@checked)
							{
								num = -28;
								goto IL_08;
							}
							goto IL_1A9;
						}
						case 6:
							this.rs.Fields["DOB"].Value = this.DateTimePicker1.Value;
							num = -5;
							goto IL_08;
						case 7:
							num = -25;
							goto IL_08;
						case 8:
							num = -1;
							goto IL_08;
						case 9:
						{
							RuntimeMethodHandle runtimeMethodHandle = methodof(Form5.get_cmdSchedule()).MethodHandle;
							num = -8;
							goto IL_08;
						}
						case 10:
							num = -16;
							goto IL_08;
						case 11:
							this.rs.Fields["Title"].Value = this.cboTitle.Text;
							num = -7;
							goto IL_08;
						case 12:
							this.rs.Fields["LastName"].Value = this.txtLastName.Text;
							num = Form7.mqgfoefwabbyeu(23);
							goto IL_08;
						case 13:
							goto IL_1A6;
						default:
							num2 = -31;
							continue;
						}
						break;
					case 1:
						goto IL_3D;
					case 2:
					{
						RuntimeMethodHandle runtimeMethodHandle2 = methodof(Form5.display()).MethodHandle;
						num2 = Form12.wsyoqrrjsoniul(48);
						continue;
					}
					case 3:
						goto IL_08;
					}
					IL_23:
					num2 = Form6.sbdifomqugmuko(61);
					continue;
					IL_08:
					num ^= 86;
					goto IL_23;
				}
			}
			IL_1A6:
			bool flag = false;
			goto IL_1AC;
			IL_1A9:
			flag = true;
			IL_1AC:
			if (!flag)
			{
				this.rs.Fields["Gender"].Value = this.rbMale.Text;
				for (;;)
				{
					int num3 = 8;
					for (;;)
					{
						switch (num3 ^ 81)
						{
						case 89:
							num3 = 10;
							continue;
						case 90:
						{
							RuntimeMethodHandle runtimeMethodHandle3 = methodof(Form5.set_txtEmail(TextBox)).MethodHandle;
							num3 = 11;
							continue;
						}
						case 91:
							num3 = 13;
							continue;
						case 92:
							goto IL_215;
						}
						break;
					}
				}
				IL_215:;
			}
			else
			{
				bool checked2 = this.rbFemale.Checked;
				if (checked2)
				{
					this.rs.Fields["Gender"].Value = this.rbFemale.Text;
				}
			}
			this.rs.Fields["School"].Value = this.cboSchool.Text;
			for (;;)
			{
				int num4 = Form7.mqgfoefwabbyeu(29);
				for (;;)
				{
					num4 ^= 89;
					switch (num4 + 85)
					{
					case 0:
						num4 = -9;
						continue;
					case 1:
						this.rs.Fields["Email"].Value = this.txtEmail.Text;
						num4 = -20;
						continue;
					case 2:
					{
						RuntimeMethodHandle runtimeMethodHandle4 = methodof(Form5.set_txtLastName(TextBox)).MethodHandle;
						num4 = -12;
						continue;
					}
					case 3:
						Interaction.MsgBox("Record Updated Successfully.", MsgBoxStyle.Information, null);
						num4 = -18;
						continue;
					case 4:
						num4 = -24;
						continue;
					case 5:
						num4 = -19;
						continue;
					case 6:
						this.rs.Fields["PhoneNo"].Value = this.txtPhone.Text;
						num4 = -21;
						continue;
					case 7:
						num4 = -11;
						continue;
					case 8:
						num4 = -31;
						continue;
					case 9:
						this.rs.Fields["Passowrd"].Value = this.txtPassword.Text;
						num4 = -14;
						continue;
					case 10:
						num4 = Form6.sbdifomqugmuko(62);
						continue;
					case 11:
						this.rs.Fields["Photo"].Value = this.str;
						num4 = -23;
						continue;
					case 12:
						this.rs.Update(RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value));
						num4 = -22;
						continue;
					case 13:
						return;
					}
					break;
				}
			}
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x00018638 File Offset: 0x00016838
		private void vsvsbbpqacuxsp(object cm, EventArgs cn)
		{
			for (;;)
			{
				IL_EE:
				int num = Form7.mqgfoefwabbyeu(31);
				int num2 = -30;
				for (;;)
				{
					num2 ^= 83;
					for (;;)
					{
						IL_3C:
						int num3 = 4;
						int num4 = -6;
						for (;;)
						{
							num4 ^= 83;
							switch (num4 + 90)
							{
							case 0:
								goto IL_3C;
							case 1:
								switch (num3)
								{
								case 83:
									break;
								case 84:
									switch (num2 + 82)
									{
									case 0:
										goto IL_A2;
									case 1:
										switch (num + 91)
										{
										case 0:
											num = -4;
											goto IL_0B;
										case 1:
											yupufqwjlhlkfh.whvgmsxtmdbkxx.hcphoarosyelxi.txtUsername.Text = "";
											num = -2;
											goto IL_0B;
										case 2:
											yupufqwjlhlkfh.whvgmsxtmdbkxx.hcphoarosyelxi.txtPassword.Text = "";
											num = -13;
											goto IL_0B;
										case 3:
											num = -14;
											goto IL_0B;
										case 4:
											base.Hide();
											num = -9;
											goto IL_0B;
										case 5:
										{
											RuntimeMethodHandle runtimeMethodHandle = methodof(Form5.get_Label1()).MethodHandle;
											num = Form7.mqgfoefwabbyeu(23);
											goto IL_0B;
										}
										case 6:
											num = -11;
											goto IL_0B;
										case 7:
											num = -10;
											goto IL_0B;
										case 8:
											yupufqwjlhlkfh.whvgmsxtmdbkxx.hcphoarosyelwz.Show();
											num = -16;
											goto IL_0B;
										case 9:
											return;
										}
										goto Block_2;
									case 2:
										goto IL_EE;
									case 3:
										break;
									default:
										num3 = 3;
										goto IL_19;
									}
									IL_0B:
									num ^= 91;
									break;
								case 85:
								{
									RuntimeMethodHandle runtimeMethodHandle2 = methodof(Form5.set_txtID(TextBox)).MethodHandle;
									num3 = 5;
									goto IL_19;
								}
								case 86:
									goto IL_9D;
								default:
									num4 = Form7.mqgfoefwabbyeu(27);
									continue;
								}
								num2 = Form2.uwpnsrqhswlmjh(42);
								num3 = 6;
								goto IL_19;
							case 2:
							{
								RuntimeMethodHandle runtimeMethodHandle3 = methodof(Form5.set_cboSchool(ComboBox)).MethodHandle;
								num4 = -5;
								continue;
							}
							case 3:
								goto IL_19;
							}
							IL_32:
							num4 = Form12.wsyoqrrjsoniul(58);
							continue;
							IL_19:
							num3 ^= 80;
							goto IL_32;
						}
					}
					IL_9D:
					continue;
					IL_A2:
					RuntimeMethodHandle runtimeMethodHandle4 = methodof(Form5.set_txtPhone(TextBox)).MethodHandle;
					num2 = -3;
					continue;
					Block_2:
					num2 = Form12.wsyoqrrjsoniul(52);
				}
			}
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x00018830 File Offset: 0x00016A30
		private void vsvsbbpqacuxsq(object co, EventArgs cp)
		{
			for (;;)
			{
				IL_A8:
				int num = 6;
				int num2 = 1;
				for (;;)
				{
					num2 ^= 91;
					for (;;)
					{
						IL_52:
						int num3 = Form12.wsyoqrrjsoniul(51);
						int num4 = -23;
						for (;;)
						{
							num4 ^= 89;
							switch (num4 + 83)
							{
							case 0:
								switch (num3 + 84)
								{
								case 0:
									switch (num2)
									{
									case 87:
										goto IL_A8;
									case 88:
										goto IL_B1;
									case 89:
										switch (num)
										{
										case 90:
											num = 4;
											goto IL_0B;
										case 91:
										{
											RuntimeMethodHandle runtimeMethodHandle = methodof(Form5.get_Label3()).MethodHandle;
											num = 1;
											goto IL_0B;
										}
										case 92:
											base.Hide();
											num = 0;
											goto IL_0B;
										case 93:
											num = 5;
											goto IL_0B;
										case 94:
											yupufqwjlhlkfh.whvgmsxtmdbkxx.hcphoarosyelxc.Show();
											num = 7;
											goto IL_0B;
										case 95:
											return;
										}
										goto Block_2;
									case 90:
										break;
									default:
										num3 = -5;
										goto IL_1C;
									}
									IL_0B:
									num ^= 90;
									break;
								case 1:
								{
									RuntimeMethodHandle runtimeMethodHandle2 = methodof(Form5.set_lblPassword(Label)).MethodHandle;
									num3 = -8;
									goto IL_1C;
								}
								case 2:
									break;
								case 3:
									goto IL_A3;
								default:
									num4 = Form7.mqgfoefwabbyeu(32);
									continue;
								}
								num2 = 2;
								num3 = -6;
								goto IL_1C;
							case 1:
								goto IL_52;
							case 2:
							{
								RuntimeMethodHandle runtimeMethodHandle3 = methodof(Form5.set_Label1(Label)).MethodHandle;
								num4 = -10;
								continue;
							}
							case 3:
								goto IL_1C;
							}
							IL_35:
							num4 = Form12.wsyoqrrjsoniul(58);
							continue;
							IL_1C:
							num3 ^= 85;
							goto IL_35;
						}
					}
					IL_A3:
					continue;
					IL_B1:
					RuntimeMethodHandle runtimeMethodHandle4 = methodof(Form5.get_cboTitle()).MethodHandle;
					num2 = 3;
					continue;
					Block_2:
					num2 = 12;
				}
			}
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x000189B4 File Offset: 0x00016BB4
		private void vsvsbbpqacuxsr(object cq, EventArgs cr)
		{
			for (;;)
			{
				IL_9A:
				int num = 1;
				int num2 = -13;
				for (;;)
				{
					num2 ^= 88;
					for (;;)
					{
						IL_57:
						int num3 = 1;
						int num4 = 9;
						for (;;)
						{
							switch (num4 ^ 85)
							{
							case 89:
								switch (num3)
								{
								case 86:
									switch (num2 + 88)
									{
									case 0:
										goto IL_9A;
									case 1:
										goto IL_A4;
									case 2:
										switch (num)
										{
										case 81:
											this.txtPassword.Visible = true;
											num = 6;
											goto IL_0B;
										case 82:
											num = 4;
											goto IL_0B;
										case 83:
											num = 3;
											goto IL_0B;
										case 84:
											this.lblPassword.Visible = true;
											num = 7;
											goto IL_0B;
										case 85:
										{
											RuntimeMethodHandle runtimeMethodHandle = methodof(Form5..ctor()).MethodHandle;
											num = 0;
											goto IL_0B;
										}
										case 86:
											return;
										}
										goto Block_2;
									case 3:
										break;
									default:
										num3 = 15;
										goto IL_1C;
									}
									IL_0B:
									num ^= 85;
									break;
								case 87:
								{
									RuntimeMethodHandle runtimeMethodHandle2 = methodof(Form5.set_Label7(Label)).MethodHandle;
									num3 = 0;
									goto IL_1C;
								}
								case 88:
									break;
								case 89:
									goto IL_95;
								default:
									num4 = 14;
									continue;
								}
								num2 = Form12.wsyoqrrjsoniul(53);
								num3 = 14;
								goto IL_1C;
							case 90:
							{
								RuntimeMethodHandle runtimeMethodHandle3 = methodof(Form5.set_Label3(Label)).MethodHandle;
								num4 = 15;
								continue;
							}
							case 91:
								goto IL_57;
							case 92:
								goto IL_1C;
							}
							IL_35:
							num4 = 12;
							continue;
							IL_1C:
							num3 ^= 87;
							goto IL_35;
						}
					}
					IL_95:
					continue;
					IL_A4:
					RuntimeMethodHandle runtimeMethodHandle4 = methodof(Form5.get_Label4()).MethodHandle;
					num2 = -15;
					continue;
					Block_2:
					num2 = Form7.mqgfoefwabbyeu(19);
				}
			}
		}

		// Token: 0x040000A8 RID: 168
		private IContainer components;

		// Token: 0x040000C7 RID: 199
		private Connection con;

		// Token: 0x040000C8 RID: 200
		private Recordset rs;

		// Token: 0x040000C9 RID: 201
		private string str;
	}
}
